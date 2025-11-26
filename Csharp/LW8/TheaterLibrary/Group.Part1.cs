using System;
using System.Collections;
using System.Collections.Generic;

namespace TheaterLibrary
{
    public partial class Group : IEnumerable<Theater>
    {
        private readonly SortedSet<Theater> items = new SortedSet<Theater>();

        public event TheaterAddedHandler? TheaterAdded;
        public event EventHandler<TheaterEventArgs>? GroupCleared;
        public event Func<Theater, bool>? FilterUsed;

        partial void OnTheaterAdded(Theater item);

        public void Add(Theater item)
        {
            if (item != null && items.Add(item))
            {
                TheaterAdded?.Invoke(item);
            }
        }

        public bool Remove(Theater item)
        {
            return items.Remove(item);
        }

        public void Clear()
        {
            items.Clear();
            GroupCleared?.Invoke(this, new TheaterEventArgs(null, "Групу очищено"));
        }

    }
}
