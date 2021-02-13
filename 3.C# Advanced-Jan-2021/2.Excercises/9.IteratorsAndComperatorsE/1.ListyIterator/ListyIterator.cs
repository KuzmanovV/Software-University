using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1.ListyIterator
{
    public class ListyIterator<T>: IEnumerable<T>
    {
        private List<T> Items;
        private int index;
        public ListyIterator(List<T> items)
        {
            this.Items = items;
        }
        public bool Move()
        {
            bool hasNext = HasNext();
            if (hasNext)
            {
                index++;
            }

            return (hasNext);
        }
        public bool HasNext()
        {
            return index < Items.Count - 1;
        }
        public void Print()
        {
            if (index>=Items.Count)
            {
                throw new InvalidOperationException("Invalid operation!");
            }

            Console.WriteLine(Items[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return GetEnumerator();
        }
    }
}
