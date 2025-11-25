namespace lr1_3
{
    public class TheaterFactory
    {
        public OperaTheater CreateOperaTheater(
            string name,
            string genre,
            string description,
            DateTime date,
            string composer,
            string language,
            bool subtitles)
        {
            return new OperaTheater
            {
                Name = name,
                Genre = genre,
                Description = description,
                Date = date,
                Composer = composer,
                Language = language,
                Subtitles = subtitles
            };
        }

        public PuppetTheater CreatePuppetTheater(
            string name,
            string genre,
            string description,
            DateTime date,
            string puppetType,
            string ageCategory)
        {
            return new PuppetTheater
            {
                Name = name,
                Genre = genre,
                Description = description,
                Date = date,
                PuppetType = puppetType,
                AgeCategory = ageCategory
            };
        }
    }
}
