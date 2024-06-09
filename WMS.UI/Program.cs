using Microsoft.Extensions.DependencyInjection;
using StackExchange.Profiling;
using WMS.BusinessLogicLayer;
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

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form_Main>());
        }

        private static IServiceCollection ConfigureServices
        {
            get
            {
                var services = new ServiceCollection();

                services.BusinessLogicConfigure();

                services.AddTransient<Form_Main>();

                return services;
            }
        }
    }
}