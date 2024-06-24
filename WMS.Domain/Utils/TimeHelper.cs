namespace WMS.Domain.Utils;

public static class TimeHelper
{
    public static DateTime GetCurrentTime()
    {
        var utcNow = DateTime.UtcNow;
        var localZone = TimeZoneInfo.Local;
        var localTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localZone);

        return localTime;
    }

    public static string ToFormat(this DateTime value, string format = "dd/MM/yyyy")
    {
        return value.ToString(format);
    }
}