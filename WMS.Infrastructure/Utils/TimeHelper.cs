namespace WMS.Infrastructure.Utils;

public static class TimeHelper
{
    public static DateTime GetLocalTime()
    {
        var utcNow = DateTime.UtcNow;
        var localZone = TimeZoneInfo.Local;
        var localTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localZone);

        return localTime;
    }
}