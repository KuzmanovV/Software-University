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
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int taskForKill = int.Parse(Console.ReadLine());

            bool removedCurrentTask = true;
            int currentTask = 0;
            int currentThread = 0;
            while (true)
            {
                currentTask = tasks.Peek();
                currentThread = threads.Dequeue();

                if (currentTask == taskForKill)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {taskForKill}");
                    Console.Write(currentThread + " ");

                    foreach (var item in threads)
                    {
                        Console.Write(item + " ");
                    }

                    break;
                }

                if (currentTask <= currentThread)
                {
                    tasks.Pop();
                }
            }
        }
    }
}
