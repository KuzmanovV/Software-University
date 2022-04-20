using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3.Stack
{
    public class MyStack<T>:IEnumerable<T>
    {
        private List<T> Items;
        public MyStack()
        {
            Items = new List<T>();
        }
        public MyStack(List<T> items)
        {
            Items = items;
        }
        public void Push(T item)
        {
            Items.Add(item);
        }

        public void Pop()
        {
            if (Items.Count==0)
            {
                throw new InvalidOperationException("No elements!");
            }            
            
            Items.RemoveAt(Items.Count-1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
