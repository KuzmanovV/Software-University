using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            int reserve = 0;
            int wreaths = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int tryWreath = lilies.Pop() + roses.Dequeue();

                if (tryWreath == 15)
                {
                    wreaths++;
                }
                else if (tryWreath<15)
                {
                    reserve += tryWreath;
                }
                else
                {
                    if (tryWreath%2!=0)
                    {
                        wreaths++;
                    }
                    else
                    {
                        reserve += 14;
                    }
                }
            }

            wreaths += reserve / 15;

            if (wreaths>4)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreaths} wreaths more!");
            }
        }
    }
}
