using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlManagmentStudio.Windows.SqlClient
{
    public interface ISqlServerClient
    {
        ConnectionState ConnectionState { get; }
        List<string> DataBasesNames { get; set; }
        void ConnectToServer(string connectionString);
        Task ConnectToServerAsync(string connectionString);
        void DisConnectFromTheServer();
        Task DisConnectFromTheServerAsync();
        SqlQueryExecutionResult ExecuteQuery(string sqlQuery, string databaseName);
        TreeNode GetServerPathAsTreeNode();
    }
}