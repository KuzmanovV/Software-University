using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = ranges[0];
            int end = ranges[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateRange = (s, e) =>
            {
                List<int> nums = new List<int>();
                
                for (int i = s; i <= e; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateRange(start, end);

            Predicate<int> predicate = x => true;

            if (criteria=="even")
            {
                predicate = x => x % 2 == 0;
            }
            else if(criteria=="odd")
            {
                predicate = x => x % 2 != 0;
            }

            Console.WriteLine(string.Join(" ", MyWhere(numbers, predicate)));
        }

        static List<int> MyWhere (List<int> nums, Predicate<int> predicate)
        {
            List<int> newNums = new List<int>();

            foreach (var num in nums)
            {
                if (predicate(num))
                {
                    newNums.Add(num);
                }
            }

            return newNums;
        }
    }
}
