using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Net;
using Microsoft.Win32;

namespace SqlManagmentStudio.Windows.Utilities
{
    public static class SqlServerInfo
    {
        public static List<string> GetDataSourceName()
        {
            List<string> _dataSourcesName = new List<string>();
            string serverName = Dns.GetHostName();
            string instanceServerName = default;
            string connectionString = default;

            using (RegistryKey serverRegistryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server"))
            {
                string[] serverInstanceName = serverRegistryKey.GetValue("InstalledInstances") as string[];
                if (serverInstanceName[0] is null)
                {
                    return null;
                }

                instanceServerName = serverInstanceName[0];
            }

            if (instanceServerName is "MSSQLSERVER")
            {
                connectionString = $"Data Source={serverName}; Integrated Security=True;";
            }
            if (instanceServerName is "SQLEXPRESS")
            {
                serverName += @$"\{instanceServerName}";
                connectionString = $"Data Source={serverName}; Integrated Security=True;";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
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
