using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public Box(List<T> values)
        {
            Values = values;
        }

        public List<T> Values { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            T container = Values[firstIndex];
            Values[firstIndex] = Values[secondIndex];
            Values[secondIndex] = container;
        }
    }
}
