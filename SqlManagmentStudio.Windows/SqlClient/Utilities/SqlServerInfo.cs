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
            try
            {
                List<string> _dataSourcesName = new List<string>();
                string connectionString = "Data Source=.; Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT @@SERVERNAME AS 'Server Name'", con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                _dataSourcesName.Add(dr[0].ToString());
                            }
                        }
                    }

                    return _dataSourcesName;
                }
            }
            catch
            {
                return null;
            }
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
