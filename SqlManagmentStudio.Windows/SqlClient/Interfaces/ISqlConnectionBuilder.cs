namespace SqlManagmentStudio.Windows.SqlClient
{
    public interface ISqlConnectionBuilder
    {
        string BuildForWindowsAuthentication(string serverName);
        string BuildForSqlAuthentication(string serverName, string login, string password);
    }
}