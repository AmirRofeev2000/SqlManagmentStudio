using Microsoft.Win32;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SqlManagmentStudio.Windows.Utilities
{
    public static class SqlServerInfo
    {
        public static List<string> GetDataSourceName()
        {
           
                List<string> _dataSourcesName = new List<string>();

                RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Microsoft SQL Server\150\Machines");
                string instance = rk.GetValue("OriginalMachineName") as string;

                if (instance is not null)
                {
                    _dataSourcesName.Add(instance);
                }

                return _dataSourcesName;
        }
        public static string GetSqlServerVersion(string connectionString)
        {
            DataTable table = new DataTable("Tables");
            SqlConnection _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "select @@version";
            table.Load(command.ExecuteReader());

            foreach (DataRow row in table.Rows)
            {
                string sqlVersion = row.ItemArray[0] as string;
                _sqlConnection.Close();
                return Regex.Match(sqlVersion, @".+Server \d+").Value;
            }

            return null;
        }
    }
}
