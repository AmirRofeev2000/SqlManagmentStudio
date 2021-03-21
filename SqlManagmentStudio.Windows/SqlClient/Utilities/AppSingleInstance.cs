using System.Threading;

namespace SqlManagmentStudio.Windows.SqlClient.Utilities
{
    public static class AppSingleInstance
    {
        private static Mutex mutex;
        public static bool Start(string applicationIdentifier)
        {
            bool isSingleInstance = false;
            mutex = new Mutex(true, applicationIdentifier, out isSingleInstance);
            return isSingleInstance;
        }
        public static void Stop()
        {
            mutex.ReleaseMutex();
        }
    }
}
