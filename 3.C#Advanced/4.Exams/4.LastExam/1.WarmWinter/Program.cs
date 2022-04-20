using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            List<int> sets = new List<int>();
            bool AreEqual = false;
            while (hats.Count!=0&&scarfs.Count!=0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if (AreEqual)
                {
                    hat++;
                }

                AreEqual = false;
                if (hat>scarf)
                {
                    sets.Add(hat+scarfs.Dequeue());
                    hats.Pop();
                }
                else if (scarf>hat)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    AreEqual = true;
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.OrderByDescending(s=>s).FirstOrDefault()}");
            Console.WriteLine(string.Join(" ",sets));
        }
    }
}
