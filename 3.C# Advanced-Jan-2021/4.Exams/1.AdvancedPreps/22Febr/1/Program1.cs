using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Input
            Queue<int> box1Queue = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> box2Stack = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int loot = 0;
            int currentBox2 = 0;
            while (box1Queue.Count!=0 && box2Stack.Count!=0)
            {
                currentBox2 = box2Stack.Pop();
                int sum = currentBox2 + box1Queue.Peek();

                if (sum%2==0)
                {
                    loot += sum;
                    box1Queue.Dequeue();
                }
                else
                {
                    box1Queue.Enqueue(currentBox2);
                }
            }

            if (box1Queue.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (loot>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {loot}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {loot}");
            }
        }
    }
}
