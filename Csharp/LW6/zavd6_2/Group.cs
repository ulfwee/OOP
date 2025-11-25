using System;
using System.Collections;
using System.Collections.Generic;

namespace lr1_3
{
    public class Group : IEnumerable<Theater>
    {
        private readonly List<Theater> items = new();

        public event TheaterAddedHandler? TheaterAdded;
        public event EventHandler<TheaterEventArgs>? GroupCleared;
        public event Func<Theater, bool>? FilterUsed;

        public void Add(Theater item)
        {
            if (item != null)
            {
                items.Add(item);
                TheaterAdded?.Invoke(item);
            }
        }

        public void Clear()
        {
            items.Clear();
            GroupCleared?.Invoke(this, new TheaterEventArgs(null, "Групу очищено"));
        }

        public IEnumerable<Theater> Filter(Func<Theater, bool> predicate)
        {
            FilterUsed?.Invoke(null);
            foreach (var t in items)
            {
                if (predicate(t))
                    yield return t;
            }
        }

        public IEnumerator<Theater> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();
    }
}
