using Microsoft.Extensions.Configuration;

namespace WMS.Infrastructure.Common
{
    public class AppConfig
    {
        public static class Database
        {
            #region File cấu hình và tên chuổi kết nối sql
            private const string ConfigFileName = "appsettings.json";
            private const string ConnectionName = "WMS_Connection";
            #endregion

            public static string? GetConnectionString()
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(ConfigFileName)
                    .Build();

                if (configuration.GetConnectionString(ConnectionName) is null)
                {
                    throw new ArgumentNullException($"Connection Error!!!!");
                }

                return configuration.GetConnectionString(ConnectionName);
            }
        }

        public static class Plc
        {
            public const string IpAddress = "192.168.0.1";
            public const short Rack = 0;
            public const short Slot = 1;

            public struct Address
            {
                // Status
                public const string Correct = "DB26.DBX18.0";
                public const string Incorrect = "DB26.DBX18.1";

                // Read barcode
                public const string ReadBarcode = "DB26.DBD14";

                // Location
                public const string PointX = "DB26.DBW2";
                public const string PointY = "DB26.DBW4";
                public const string PointZ = "DB26.DBW6";

                // In-out Goods
                public const string In = "DB26.DBX0.0";
                public const string Out = "DB26.DBX0.1";
            }
        }
    }
}
