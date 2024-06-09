using Microsoft.Extensions.Configuration;

namespace WMS.Infrastructure.Common
{
    public class AppConfig
    {
        #region File cấu hình và tên chuổi kết nối 
        private const string CONFIG_FILE_NAME = "appsettings.json";
        private const string CONNECTION_NAME = "WMS_Connection";
        #endregion

        public static string? GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(CONFIG_FILE_NAME)
                .Build();

            if (configuration.GetConnectionString(CONNECTION_NAME) is null)
            {
                throw new ArgumentNullException("Connection Error!!!!");
            }
            else
            {
                return configuration.GetConnectionString(CONNECTION_NAME);
            }
        }
    }
}
