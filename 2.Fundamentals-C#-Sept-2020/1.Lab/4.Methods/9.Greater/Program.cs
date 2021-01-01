using System;

namespace _9.Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMaxInt(first, second));
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMaxString(first, second));
            }
        }

        private static string GetMaxString(string first, string second)
        {
            int sumFirst = 0;
            int sumSecond = 0;

            for (int i = 0; i < first.Length; i++)
            {
                sumFirst += first[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                sumSecond += second[i];
            }

            if (sumFirst > sumSecond)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static int GetMaxInt(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}
