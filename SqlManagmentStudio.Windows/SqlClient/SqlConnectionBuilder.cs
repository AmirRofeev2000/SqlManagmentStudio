using System.Data.SqlClient;

namespace SqlManagmentStudio.Windows.SqlClient
{
    public class SqlConnectionBuilder : ISqlConnectionBuilder
    {
        public string BuildForWindowsAuthentication(string serverName)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

            connectionStringBuilder.Add("Data Source", serverName);
            connectionStringBuilder.Add("Integrated Security", "True");

            return connectionStringBuilder.ConnectionString;
        }

        public string BuildForSqlAuthentication(string serverName, string login, string password)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

            connectionStringBuilder.Add("Data Source", serverName);
            connectionStringBuilder.Add("User Id", login);
            connectionStringBuilder.Add("Password", password);

            return connectionStringBuilder.ConnectionString;
        }
    }
}
