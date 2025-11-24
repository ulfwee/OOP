using System;
using System.Collections;
using System.Collections.Generic;

namespace lr1_3
{
    public class Group : IEnumerable<Theater>
    {
        private List<Theater> items = new List<Theater>();

      
        public void Add(Theater item)
        {
            if (item != null)
                items.Add(item);
        }   

        public void Clear() => items.Clear();

        public int Count => items.Count;

        public Theater this[int index] => items[index];

        
        public IEnumerator<Theater> GetEnumerator()
        {
            foreach (var item in items)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerable<Theater> Filter(Func<Theater, bool> predicate)
        {
            foreach (var t in items)
                if (predicate(t))
                    yield return t;
        }
    }
}
