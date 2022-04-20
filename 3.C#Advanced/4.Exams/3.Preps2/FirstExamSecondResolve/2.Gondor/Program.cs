using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            bool orcsWin = false;
            int sirvivedPlate = 0;
            bool plateWon = false;

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> orcs = new Stack<int>();

            for (int i = 0; i < waves; i++)
            {
                orcs = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

                if ((i + 1) % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                int plate = 0;
                int orcsCounter = orcs.Count;
                for (int j = 0; j < orcsCounter; j++)
                {
                    int orc = orcs.Pop();
                    if (!plateWon)
                    {
                        plate = plates.Peek();
                    }
                    int fight = orc - plate;
                    //Orc wins
                    if (fight > 0)
                    {
                        orcs.Push(fight);
                        plates.Dequeue();
                        if (plates.Count == 0)
                        {
                            break;
                        }
                    }
                    //plate wins
                    else if (fight < 0)
                    {
                        plateWon = true;
                        plate = Math.Abs(fight);
                        sirvivedPlate = plate;
                    }
                    else if (fight==0)
                    {
                        plates.Dequeue();
                        if (plates.Count==0)
                        {
                            break;
                        }
                        plateWon = true;
                    }
                }

                if (plates.Count == 0)
                {
                    StringBuilder result = new StringBuilder();

                    result.AppendLine("The orcs successfully destroyed the Gondor's defense.");
                    result.Append("Orcs left: ");

                    result.Append(string.Join(", ", orcs));

                    Console.WriteLine(result.ToString());
                    orcsWin = true;
                    break;
                }
            }

            if (!orcsWin)
            {
                StringBuilder result = new StringBuilder();

                if (plateWon)
                {
                    plates.Dequeue();
                }

                result.AppendLine("The people successfully repulsed the orc's attack.");
                result.Append($"Plates left: {sirvivedPlate}");

                if (plates.Count>0)
                {
                    result.Append(", ");
                    result.Append(string.Join(", ", plates));
                }

                Console.WriteLine(result.ToString());
            }
        }
    }
}
