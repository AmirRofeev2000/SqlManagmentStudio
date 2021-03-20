using System.Data;

namespace SqlManagmentStudio.Windows.SqlClient
{
    public class SqlQueryExecutionResult
    {
        public DataTable DataSource { get; set; }
        public string Rows { get; set; }
        public string ElapsedTime { get; set; }
        public string Result { get; set; }
    }
}