using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr1_3
{
    public interface ITheater
    {
    public string Composer { get; set; }
    public string Language { get; set; }
    public bool Subtitles { get; set; }
    public string PuppetType { get; set; }
    public string AgeCategory { get; set; }
    }
   

    public interface IShow: ITheater
    {
        string Name { get; set; }
        string Genre { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }
        public string Category { get; set; }
        string GetInfo();
    }
    public class Theater : IShow
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }

        public virtual string PuppetType { get; set; } = "";
        public virtual string AgeCategory { get; set; } = "";
        public virtual string Composer { get; set; } = "";
        public virtual string Language { get; set; } = "";
        public virtual bool Subtitles { get; set; } = false;
        public virtual string GetInfo()
        {
            return $"{Name} ({Genre}) — {Date:dd.MM.yyyy}";
        }

        public override string ToString() => GetInfo();
        public static bool operator ==(Theater t1, Theater t2)
        {
            if (t1 is null && t2 is null) return true;

            if (t1 is null || t2 is null) return false;

            return t1.Name == t2.Name &&
                   t1.Genre == t2.Genre &&
                   t1.Description == t2.Description &&
                   t1.Date.Date == t2.Date.Date;
        }

        public static bool operator !=(Theater t1, Theater t2)
        {
            return !(t1 == t2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Theater other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Genre, Description, Date.Date);
        }

      
    }

    public class OperaTheater : Theater
    {


        public OperaTheater()
        {
            Category = "Оперний";
            PuppetType = "";           
            AgeCategory = "";          
        }
        public override string GetInfo()
        {
            string subs = Subtitles ? "з субтитрами" : "без субтитрів";
            return $"{Name} (Опера) — Композитор: {Composer}, Мова: {Language}, {subs}";
        }

        public static bool operator ==(OperaTheater t1, OperaTheater t2)
        {
            if (t1 is null && t2 is null) return true;

            if (t1 is null || t2 is null) return false;

            return t1.Name == t2.Name &&
                   t1.Genre == t2.Genre &&
                   t1.Description == t2.Description &&
                   t1.Date.Date == t2.Date.Date &&
                   t1.Composer == t2.Composer &&
                   t1.Language == t2.Language &&
                   t1.Subtitles == t2.Subtitles;
        }

        public static bool operator !=(OperaTheater t1, OperaTheater t2)
        {
            return !(t1 == t2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is OperaTheater other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Genre, Description, Date.Date, Composer, Language, Subtitles);
        }

    }

    public class PuppetTheater : Theater
    {
    

        public PuppetTheater()
        {
            Category = "Ляльковий";
            Composer = "";
            Language = "";
            Subtitles = false;
        }
        public override string GetInfo()
        {
            return $"{Name} (Ляльковий театр) — Тип: {PuppetType}, Вікове обмеження: {AgeCategory}";
        }

        public static bool operator ==(PuppetTheater t1, PuppetTheater t2)
        {
            if (t1 is null && t2 is null) return true;

            if (t1 is null || t2 is null) return false;

            return t1.Name == t2.Name &&
                   t1.Genre == t2.Genre &&
                   t1.Description == t2.Description &&
                   t1.Date.Date == t2.Date.Date &&
                   t1.PuppetType == t2.PuppetType &&
                   t1.AgeCategory == t2.AgeCategory;      
        }

        public static bool operator !=(PuppetTheater t1, PuppetTheater t2)
        {
            return !(t1 == t2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is PuppetTheater other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Genre, Description, Date.Date, PuppetType, AgeCategory);
        }
    }
}