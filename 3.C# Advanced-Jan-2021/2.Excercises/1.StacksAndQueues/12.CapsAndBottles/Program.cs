using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CapsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> caps = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));


        }
    }
}
