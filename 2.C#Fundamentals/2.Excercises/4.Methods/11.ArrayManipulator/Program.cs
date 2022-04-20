using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();

            string commandM = "";

            while ((commandM = Console.ReadLine()) != "end")
            {
                string[] commanded = commandM.Split(" ");

                switch (commanded[0])
                {
                        case "exchange": break;
                    case "max": break;
                    case "min": break;
                    case "first": break;


                }
            }
        }
    }
}
