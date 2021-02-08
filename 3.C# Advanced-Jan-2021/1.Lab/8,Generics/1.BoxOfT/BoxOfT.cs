using System;
using System.Collections.Generic;


namespace BoxOfT
{
    public class BoxOfT<T>
    {
        Stack<T> elements;
        public BoxOfT()
        {
            elements = new Stack<T>();
        }
        public int Count => elements.Count;

        public void Add(T element)
        {
            elements.Push(element);
        }

        public T Remove()
        {
            T removed = elements.Pop();
            return removed;
        }
    }
}
