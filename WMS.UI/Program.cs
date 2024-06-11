using Microsoft.Extensions.DependencyInjection;
using StackExchange.Profiling;
using WMS.Application;
using WMS.Infrastructure;
using WMS.UI.Forms;

namespace WMS.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MiniProfiler.StartNew();
            var services = ConfigureServices;
            var serviceProvider = services.BuildServiceProvider();

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(serviceProvider.GetRequiredService<FormMain>());
        }

        private static IServiceCollection ConfigureServices
        {
            get
            {
                var services = new ServiceCollection();

                services.AddBusinessLogic();
                services.AddInfrastructure();

                services.AddTransient<FormMain>();

                return services;
            }
        }
    }
}