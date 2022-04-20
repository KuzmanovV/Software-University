using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.GenericCountMethodStrings
{
    public class Box<T> where T: IComparable
    {
        public Box(List<T> values )
        {
            Values = values;
        }
        public List<T> Values { get; set; }

        public int GetCountGreaterElements(T forComparing)
        {
            int result = 0;

            foreach (T item in Values)
            {
                if (item.CompareTo(forComparing)>0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
