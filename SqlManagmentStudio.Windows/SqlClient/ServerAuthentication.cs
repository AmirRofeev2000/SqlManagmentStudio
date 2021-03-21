using System.Data;
using System.Data.SqlClient;
using SqlManagmentStudio.Windows.SqlClient.Utilities;

namespace SqlManagmentStudio.Windows.SqlClient
{
    public class ServerAuthentication : IServerAuthentication
    {
        private ISqlConnectionBuilder _sqlConnectionBuilder;

        public ServerAuthentication(ISqlConnectionBuilder sqlConnectionBuilder)
        {
            _sqlConnectionBuilder = sqlConnectionBuilder;
        }

        public string Authenticate(string serverName)
        {
            if (string.IsNullOrEmpty(serverName))
            {
                MessageBoxWrapper.ShowErrorBox("Server name is empty", "Please provide a server name.");
                return null;
            }

            string connectionString = _sqlConnectionBuilder.BuildForWindowsAuthentication(serverName);
            bool isValidConnectionString = ValidateConnectionString(connectionString);

            if (!isValidConnectionString)
            {
                MessageBoxWrapper.ShowErrorBox("Invalid server name", "Please provide a valid server name.");
                return null;
            }

            return connectionString;
        }
        public string Authenticate(string serverName, string login, string password)
        {
            if (string.IsNullOrEmpty(serverName) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBoxWrapper.ShowErrorBox("Fill the boxes", "Please fill all the boxes, before connecting to the server.");
                return null;
            }

            string connectionString = _sqlConnectionBuilder.BuildForWindowsAuthentication(serverName);
            bool isValidConnectionString = ValidateConnectionString(connectionString);

            if (!isValidConnectionString)
            {
                MessageBoxWrapper.ShowErrorBox("Invalid server name", "Please provide a valid server name.");
                return null;
            }

            return connectionString;
        }
        public bool ValidateConnectionString(string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return (conn.State == ConnectionState.Open);
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
