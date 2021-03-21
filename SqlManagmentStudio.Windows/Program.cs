using System;
using System.Windows.Forms;
using SqlManagmentStudio.Windows.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using SqlManagmentStudio.Windows.SqlClient.Utilities;

namespace SqlManagmentStudio.Windows
{
    static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {
            if (!AppSingleInstance.Start(Application.ProductName))
            {
                MessageBoxWrapper.ShowWarningBox("Application is already running.", "You can't open application again, because application is already running.");
                return;
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();

            Application.Run(ServiceProvider.GetService<Form>());
        }
        static void ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<ISqlConnectionBuilder, SqlConnectionBuilder>();
            services.AddSingleton<ISqlServerClient, SqlServerClient>();
            services.AddSingleton<IServerAuthentication, ServerAuthentication>(x => new ServerAuthentication(x.GetRequiredService<ISqlConnectionBuilder>()));
            services.AddSingleton<Form, SqlManagerForm>(x => new SqlManagerForm(ServiceProvider.GetRequiredService<ISqlServerClient>(), ServiceProvider.GetRequiredService<IServerAuthentication>()));
            
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
