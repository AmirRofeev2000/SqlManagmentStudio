using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlManagmentStudio.Windows.SqlClient;
using SqlManagmentStudio.Windows.SqlClient.Utilities;

namespace SqlManagmentStudio.Windows
{
    public partial class SqlManagerForm : Form
    {
        private ISqlServerClient _sqlServerClient;
        private IServerAuthentication _serverAuthentication;
        private delegate void SafeLoadTree();
        public SqlManagerForm(ISqlServerClient sqlServerClient, IServerAuthentication serverAuthentication)
        {
            InitializeComponent();
            _sqlServerClient = sqlServerClient;
            _serverAuthentication = serverAuthentication;
        }

        private void executeQuery_Btn_Click(object sender, System.EventArgs e)
        {
            string dataBaseName = databases_combo.SelectedItem as string;
            SqlQueryExecutionResult sqlQueryExecutionResult = _sqlServerClient.ExecuteQuery(sqlEditor_TextBox.Text, dataBaseName);

            queryExecutionState_Label.Text = sqlQueryExecutionResult.Result;
            elapsedTime_Label.Text = sqlQueryExecutionResult.ElapsedTime;
            rowsCount_Label.Text = sqlQueryExecutionResult.Rows;
            sqlQueryResult_GridView.DataSource = sqlQueryExecutionResult.DataSource;
        }
        private async void connectToServer_Btn_Click(object sender, System.EventArgs e)
        {
            if (_sqlServerClient.ConnectionState is ConnectionState.Closed)
            {
                LoginForm loginForm = LoginForm.CreateForm(_serverAuthentication);
                loginForm.Show();
            }
            if (_sqlServerClient.ConnectionState is ConnectionState.Open)
            {
                await DisconnectFromTheServer();
            }
        }
        public async Task ConnectToTheServer(string connectionString)
        {
            connectToServer_Btn.Enabled = false;
            await _sqlServerClient.ConnectToServerAsync(connectionString);
            EnableUIElements();
            connectToServer_Btn.Enabled = true;
        }
        public async Task DisconnectFromTheServer()
        {
            connectToServer_Btn.Enabled = false;
            await _sqlServerClient.DisConnectFromTheServerAsync();
            DisableUIElements();
            connectToServer_Btn.Enabled = true;
        }
        private void EnableUIElements()
        {

            LoadTree();

            databases_combo.Items.AddRange(_sqlServerClient.DataBasesNames.ToArray());
            databases_combo.Enabled = true;

            executeQuery_Btn.Enabled = true;

            sqlEditor_TextBox.Enabled = true;
            sqlQueryResult_GridView.Enabled = true;

            connectToServer_Btn.Text = "Disconnect";
        }
        private void DisableUIElements()
        {
            hierarchy_TreeView.Nodes.Clear();
            hierarchy_TreeView.Enabled = false;

            databases_combo.Text = "";
            databases_combo.Items.Clear();
            databases_combo.Enabled = false;

            executeQuery_Btn.Enabled = false;

            sqlEditor_TextBox.Clear();
            sqlEditor_TextBox.Enabled = false;

            sqlQueryResult_GridView.Enabled = false;
            sqlQueryResult_GridView.DataSource = null;

            connectToServer_Btn.Text = "Connect";
        }
        private void LoadTree()
        {
            hierarchy_TreeView.Enabled = true;
            TreeNode returnedTreeNode = _sqlServerClient.GetServerPathAsTreeNode();
            hierarchy_TreeView.Nodes.Add(returnedTreeNode);
        }
    }
}
