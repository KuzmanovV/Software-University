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
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            //Output
            if (effects.Count==0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.Write($"Bomb Effects: ");
                for (int i = 0; i < effects.Count-1; i++)
                {
                    Console.Write($"{effects.Dequeue()}, ");
                }
                Console.WriteLine(effects.Dequeue());
            }
        }
    }
}
