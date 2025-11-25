namespace lr1_3
{
    public class Schedule
    {
        public TimeSpan StartTime { get; set; }
        public int DurationMinutes { get; set; }

        public Schedule(TimeSpan start, int duration)
        {
            StartTime = start;
            DurationMinutes = duration;
        }

        public override string ToString()
        {
            return $"{StartTime:hh\\:mm} ({DurationMinutes} хв)";
        }
    }
}
