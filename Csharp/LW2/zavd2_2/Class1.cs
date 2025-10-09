using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr1_3
{
    public class Theater
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public static bool operator==(Theater? t1, Theater? t2)
        {
            if (t1 is null && t2 is null) return true;

            if (t1 is null || t2 is null) return false;

            return t1.Name == t2.Name &&
                   t1.Genre == t2.Genre &&
                   t1.Description == t2.Description &&
                   t1.Date.Date == t2.Date.Date;
        }

        public static bool operator !=(Theater? t1, Theater? t2)
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

        public override string ToString()
        {
            return $"{Name} ({Genre}) — {Date:dd.MM.yyyy}";
        }
    }
}
