namespace Codeer.LowCode.Bindings.MudBlazor.Internal
{
    internal class DateTimeHelper
    {
        public static DateTime ToDateTime(DateOnly date) => new(date.Year, date.Month, date.Day);
        public static DateTime? ToDateTime(DateOnly? date) => date == null ? null : ToDateTime(date.Value);
        public static DateOnly ToDateOnly(DateTime date) => new(date.Year, date.Month, date.Day);
        public static DateOnly? ToDateOnly(DateTime? date) => date == null ? null : ToDateOnly(date.Value);
        public static TimeOnly? ToUniversalTime(TimeOnly? time) => time?.AddHours(DateTimeOffset.Now.Offset.TotalHours * -1);
        public static TimeOnly? ToLocalTime(TimeOnly? time) => time?.AddHours(DateTimeOffset.Now.Offset.TotalHours);

        public static TimeOnly? ToTimeOnly(TimeSpan? value)
        {
            if (value == null) return null;
            return new TimeOnly(value.Value.Hours, value.Value.Minutes, value.Value.Seconds);
        }
    }
}
