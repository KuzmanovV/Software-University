using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        Dictionary<int, string> family = new Dictionary<int, string>();

        public void AddMember()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person p = new Person(input[0], int.Parse(input[1]));
                family[p.Age] = p.Name;
            }
        }

        public void GetOldestMember()
        {
            Console.WriteLine($"{family.Keys.Max()} { family[family.Keys.Max()]}");
        }
    }
}
