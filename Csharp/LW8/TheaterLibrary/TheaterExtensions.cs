using System;
using System.Collections.Generic;
using System.Linq;

namespace TheaterLibrary
{
    public static class TheaterExtensions
    {
        public static string Rate(this Theater show)
        {
            if (show == null)
                return "Немає даних";

            int score = 0;

            if (show.Schedule != null && show.Schedule.DurationMinutes <= 60) score += 1;
            if (show.Date > DateTime.Now) score += 1;
            if (!string.IsNullOrWhiteSpace(show.Genre)) score += 1;

            return score switch
            {
                3 => "Відмінно",
                2 => "Добре",
                1 => "Задовільно",
                _ => "Низька оцінка"
            };
        }

        public static string RateOpera(this OperaTheater opera)
        {
            if (opera == null) return "Невідома опера";

            if (opera.Subtitles && opera.Language == "Італійська")
                return "Професійна постанова";

            if (opera.Language == "Українська")
                return "Легка до сприйняття опера";

            return "Звичайна опера";
        }

        public static string RatePuppet(this PuppetTheater puppet)
        {
            if (puppet == null) return "Невідомий спектакль";

            if (puppet.AgeCategory == "0+" || puppet.AgeCategory == "3+")
                return "Дуже підходить для дітей";

            if (puppet.AgeCategory == "16+" || puppet.AgeCategory == "18+")
                return "Постановка для дорослих";

            return "Універсальний спектакль";
        }
    }
}
