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
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int cherrys = 0;
            int daturas = 0;
            int smokes = 0;
            int sum = 0;
            bool success = false;

            while (effects.Count > 0 && casings.Count > 0)
            {
                int casing = casings.Pop();
                sum = effects.Peek() + casing;

                switch (sum)
                {
                    case 60:
                        cherrys++;
                        effects.Dequeue();
                        break;
                    case 40:
                        daturas++;
                        effects.Dequeue();
                        break;
                    case 120:
                        smokes++;
                        effects.Dequeue();
                        break;
                    default:
                        casing -= 5;
                        casings.Push(casing);
                        break;
                }

                if (cherrys >= 3 && daturas >= 3 && smokes >= 3)
                {
                    success = true;
                    break;
                }
            }

            if (success)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.Write($"Bomb Effects: ");
                for (int i = 0; i < effects.Count - 1; i++)
                {
                    Console.Write($"{effects.Dequeue()}, ");
                }
                Console.WriteLine(effects.Dequeue());
            }

            if (casings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.Write($"Bomb Casings: ");
                for (int i = 0; i < casings.Count - 1; i++)
                {
                    Console.Write($"{casings.Peek()}, ");
                }
                Console.WriteLine(casings.Peek());
            }

            Console.WriteLine($"Cherry Bombs: {cherrys}");
            Console.WriteLine($"Datura Bombs: {daturas}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokes}");
        }
    }
}
