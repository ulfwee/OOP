using System;
using System.Collections;
using System.Collections.Generic;

namespace TheaterLibrary
{
    public partial class Group
    {
        public IEnumerable<Theater> Filter(Func<Theater, bool> predicate)
        {
            FilterUsed?.Invoke(null);
            foreach (var t in items)
            {
                if (predicate(t))
                    yield return t;
            }
        }

        partial void OnTheaterAdded(Theater item)
        {
            Console.WriteLine($"Partial: додано театр: {item.Name}");
        }

        public IEnumerator<Theater> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
