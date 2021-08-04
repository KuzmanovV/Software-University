using System;
using System.Linq;

namespace _10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var item in indexes)
            {
                if (item < fieldSize)
                {
                    field[item] = 1;
                }
            }

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int targetBug = int.Parse(inputArr[0]);
                int targetCell = int.Parse(inputArr[2]);

                if (field[targetBug] == 1 && field[targetBug]>=0 && field[targetBug]<fieldSize)
                {
                    field[targetBug] = 0;

                    if (inputArr[1] == "right")
                    {
                        int destination = targetBug + targetCell;

                        while (destination < fieldSize && field[destination] == 1)
                        {
                            destination++;
                        }

                        if (destination < fieldSize)
                        {
                        field[destination] = 1;
                        }
                    }
                    
                    if (inputArr[1] == "left")
                    {
                        int destination = targetBug - targetCell;

                        while (destination >= 0 && field[destination] == 1)
                        {
                            destination--;
                        }

                        if (destination >= 0)
                        {
                        field[destination] = 1;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
