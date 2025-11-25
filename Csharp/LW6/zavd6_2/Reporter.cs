namespace lr1_3
{
    public class TheaterReporter
    {
        public string ShortInfo(Theater t)
        {
            return $"[{t.Category}] {t.Name} — {t.Date:dd.MM.yyyy}";
        }
    }
}
