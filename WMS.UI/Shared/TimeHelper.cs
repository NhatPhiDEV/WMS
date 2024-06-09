namespace WMS.UI.Shared
{
    public static class TimeHelper
    {
        public static DateTime GetLocalTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localZone);

            return localTime;
        }
    }
}
