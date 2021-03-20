namespace SqlManagmentStudio.Windows.SqlClient
{
    public interface IServerAuthentication
    {
        string Authenticate(string serverName);
        string Authenticate(string serverName, string login, string password);
        bool ValidateConnectionString(string connectionString);
    }
}