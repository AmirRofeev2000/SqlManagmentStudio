using System;
using System.Windows.Forms;
using SqlManagmentStudio.Windows.SqlClient;
using Microsoft.Extensions.DependencyInjection;

namespace SqlManagmentStudio.Windows
{
    static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();

            Application.Run(new SqlManagerForm(ServiceProvider.GetService<ISqlServerClient>(), ServiceProvider.GetService<IServerAuthentication>()));
        }

        static void ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();
            
            services.AddSingleton<ISqlConnectionBuilder, SqlConnectionBuilder>();
            
            ServiceProvider sqlConnectionBuilderProvider = services.BuildServiceProvider();

            services.AddSingleton<ISqlServerClient, SqlServerClient>();
            services.AddSingleton<IServerAuthentication, ServerAuthentication>(cont => new ServerAuthentication(sqlConnectionBuilderProvider.GetService<ISqlConnectionBuilder>()));

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
