using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SqlManagmentStudio.Windows.Utilities
{
    public static class SqlServerInfo
    {
        public static List<string> GetDataSourceName()
        {
            List<string> _dataSourcesName = new List<string>();
            string serverName = System.Net.Dns.GetHostName();
            string connectionString;
            try
            {
                connectionString = $"Data Source={serverName}; Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                }
                _dataSourcesName.Add(serverName);
            }
            catch
            {
                connectionString = @$"Data Source={serverName}\SQLEXPRESS; Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    serverName = serverName + @"/SQLEXPRESS";
                    con.Open();
                }
                _dataSourcesName.Add(serverName);
            }
            if (_dataSourcesName.Count > 0)
            {
                return _dataSourcesName;
            }

            return null;
        }

        public static string GetSqlServerVersion(string connectionString)
        {
            DataTable table = new DataTable("Tables");
            using (SqlConnection _sqlConnection = new SqlConnection(connectionString))
            {
                _sqlConnection.Open();
                SqlCommand command = _sqlConnection.CreateCommand();
                command.CommandText = "select @@version";
                table.Load(command.ExecuteReader());

                foreach (DataRow row in table.Rows)
                {
                    string sqlVersion = row.ItemArray[0] as string;
                    return Regex.Match(sqlVersion, @".+Server \d+").Value;
                }
            }

            return null;
        }
    }
}
