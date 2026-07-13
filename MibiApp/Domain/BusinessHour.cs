namespace MibiApp.Domain
{
    public class BusinessHour
    {
        public int Id { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public bool IsOpen { get; set; }
    }
}
