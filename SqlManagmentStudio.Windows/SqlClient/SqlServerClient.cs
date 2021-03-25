using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using SqlManagmentStudio.Windows.Utilities;

namespace SqlManagmentStudio.Windows.SqlClient
{
    public class SqlServerClient : ISqlServerClient
    {
        private SqlConnection _sqlConnection;
        private string _connectionString;

        public ConnectionState ConnectionState
        {
            get
            {
                if (_sqlConnection is null)
                {
                    return ConnectionState.Closed;
                }
                return _sqlConnection.State;
            }

        }
        public List<string> DataBasesNames { get; set; }
        public void ConnectToServer(string connectionString)
        {
            _connectionString = connectionString;
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
        }
        public async Task ConnectToServerAsync(string connectionString)
        {
            _connectionString = connectionString;
            _sqlConnection = new SqlConnection(connectionString);
            await _sqlConnection.OpenAsync();
        }
        public void DisConnectFromTheServer()
        {
            _sqlConnection.Close();
        }
        public async Task DisConnectFromTheServerAsync()
        {
            await _sqlConnection.CloseAsync();
        }
        public SqlQueryExecutionResult ExecuteQuery(string sqlQuery, string databaseName)
        {
            SqlQueryExecutionResult sqlQueryExecutionResult = new SqlQueryExecutionResult();

            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();

                _sqlConnection.ChangeDatabase(databaseName);
                adapter.SelectCommand = new SqlCommand(sqlQuery, _sqlConnection);

                adapter.Fill(dataSet, "resultData");
                sw.Stop();

                sqlQueryExecutionResult.Result = "Query executed successfully";
                sqlQueryExecutionResult.ElapsedTime = $"Elapsed Time: {sw.Elapsed}";
                sqlQueryExecutionResult.Rows = $"Rows: {dataSet.Tables["resultData"].Rows.Count}";
                sqlQueryExecutionResult.DataSource = dataSet.Tables["resultData"];
            }
            catch
            {
                sqlQueryExecutionResult.Result = "Query wasn't executed successfully";
                sqlQueryExecutionResult.ElapsedTime = "Elapsed Time: 00:00:00";
                sqlQueryExecutionResult.Rows = "Rows: 0";
                sqlQueryExecutionResult.DataSource = null;
            }

            return sqlQueryExecutionResult;
        }
        public TreeNode GetServerPathAsTreeNode()
        {
            TreeNode startTreeNode = new TreeNode();
            startTreeNode.Text = SqlServerInfo.GetSqlServerVersion(_connectionString);

            foreach (TreeNode node in GetServerPath())
            {
                startTreeNode.Nodes.Add(node);
            }

            return startTreeNode;
        }
        private TreeNodeCollection GetServerPath()
        {
            TreeNodeCollection serverPathTreeNode = GetDatabasesName();
            serverPathTreeNode = GetDatabasesTableAndColumnsName(serverPathTreeNode);

            return serverPathTreeNode;
        }
        private TreeNodeCollection GetDatabasesName()
        {
            TreeNode startDatabaseNode = new TreeNode();
            TreeNodeCollection databasesNameCollection = startDatabaseNode.Nodes;
            DataBasesNames = new List<string>();
            DataTable tableDatabases = _sqlConnection.GetSchema("Databases");

            foreach (DataRow row in tableDatabases.Rows)
            {
                string dataBaseName = row["database_name"] as string;
                databasesNameCollection.Add(dataBaseName);

                DataBasesNames.Add(dataBaseName);
            }

            return databasesNameCollection;
        }
        private TreeNodeCollection GetDatabasesTableAndColumnsName(TreeNodeCollection databasesNameCollection)
        {
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "select table_name as TableName from INFORMATION_SCHEMA.Tables where TABLE_TYPE = 'BASE TABLE'";
            List<TreeNode> foo = new List<TreeNode>();

            foreach (TreeNode databaseNameNode in databasesNameCollection)
            {
                _sqlConnection.ChangeDatabase(databaseNameNode.Text);
                DataTable tables = new DataTable("Tables");
                tables.Load(command.ExecuteReader());

                foreach (DataRow row in tables.Rows)
                {
                    string name = row.ItemArray[0].ToString();
                    TreeNode tableNameTreeNode = new TreeNode(name);
                    tableNameTreeNode = GetTablesColumnsName(tableNameTreeNode.Text);

                    databaseNameNode.Nodes.Add(tableNameTreeNode);
                }
            }

            return databasesNameCollection;
        }
        private TreeNode GetTablesColumnsName(string tableName)
        {
            TreeNode tableNodeWithColumnNames = new TreeNode(tableName);

            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='{tableName}'";
            DataTable table = new DataTable(tableName);
            table.Load(command.ExecuteReader());

            foreach (DataRow row in table.Rows)
            {
                string columnName = row.ItemArray[0] as string;
                TreeNode columnTreeNode = new TreeNode(columnName);
                tableNodeWithColumnNames.Nodes.Add(columnTreeNode);
            }
            return tableNodeWithColumnNames;
        }
    }
}
