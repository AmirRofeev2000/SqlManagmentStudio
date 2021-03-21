using System;
using System.Windows.Forms;
using SqlManagmentStudio.Windows.SqlClient;
using SqlManagmentStudio.Windows.SqlClient.Utilities;
using SqlManagmentStudio.Windows.Utilities;

namespace SqlManagmentStudio.Windows
{
    public partial class LoginForm : Form
    {
        public AuthenticationType _authenticationType;
        private IServerAuthentication _serverAuthentication;
        private static LoginForm _loginForm;
        public LoginForm(IServerAuthentication serverAuthentication)
        {
            InitializeComponent();
            string[] dataSourceNames = null;
            try
            {
                dataSourceNames = SqlServerInfo.GetDataSourceName().ToArray();
                serverName_Dropdown.Items.AddRange(dataSourceNames);
                authenticationType_ComboBox.SelectedIndex = 0;
                serverName_Dropdown.SelectedIndex = 0;
                _serverAuthentication = serverAuthentication;
            }
            catch (Exception)
            {
                if (dataSourceNames is null)
                {
                    MessageBoxWrapper.ShowErrorBox("None Sql Server Instances", "No Sql Server Instances were found in your computer");
                }
            }
        }

        public static LoginForm CreateForm(IServerAuthentication serverAuthentication)
        {
            if (_loginForm is null || _loginForm.IsDisposed)
            {
                _loginForm = new LoginForm(serverAuthentication);
            }

            return _loginForm;
        }

        private void closeLogin_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void connectToServer_Btn_Click(object sender, EventArgs e)
        {
            string connectionString;
            if (_authenticationType is AuthenticationType.WindowsAuthentication)
            {
                connectionString = _serverAuthentication.Authenticate(serverName_Dropdown.Text);
                if (!string.IsNullOrEmpty(connectionString))
                {
                    if (Application.OpenForms["SqlManagerForm"] != null)
                    {
                        this.Close();
                        await (Application.OpenForms["SqlManagerForm"] as SqlManagerForm).ConnectToTheServer(connectionString);
                    }
                }
            }
            if (_authenticationType is AuthenticationType.SqlServerAuthentication)
            {
                connectionString = _serverAuthentication.Authenticate(serverName_Dropdown.Text, loginName_TextBox.Text, passwordName_TextBox.Text);

                if (!string.IsNullOrEmpty(connectionString))
                {
                    if (Application.OpenForms["SqlManagerForm"] != null)
                    {
                        this.Close();
                        await (Application.OpenForms["SqlManagerForm"] as SqlManagerForm).ConnectToTheServer(connectionString);
                    }
                }
            }
        }
        private void authenticationType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string authenticationType = authenticationType_ComboBox.SelectedItem as string;

            if (authenticationType == "Windows Authentication")
            {
                loginName_TextBox.Enabled = false;
                passwordName_TextBox.Enabled = false;
                _authenticationType = AuthenticationType.WindowsAuthentication;
            }

            if (authenticationType == "Sql Server Authentication")
            {
                loginName_TextBox.Enabled = true;
                passwordName_TextBox.Enabled = true;
                _authenticationType = AuthenticationType.SqlServerAuthentication;
            }
        }
    }
}
