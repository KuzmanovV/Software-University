using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSizeInput = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int targetValue = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);
            int barrelSize = barrelSizeInput;

            while (bulletsStack.Count>0 && locksQueue.Count>0)
            {
                if (bulletsStack.Peek()<=locksQueue.Peek())
                {
                    locksQueue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                bulletsStack.Pop();
                barrelSize--;

                if (barrelSize==0 && bulletsStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    barrelSize = barrelSizeInput;
                }
            }

            if (barrelSize == 0 && bulletsStack.Count>0)
            {
                Console.WriteLine("Reloading!");
            }

            if (locksQueue.Count==0)
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. " +
                    $"Earned ${targetValue-((bullets.Length-bulletsStack.Count)*bulletPrice)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
