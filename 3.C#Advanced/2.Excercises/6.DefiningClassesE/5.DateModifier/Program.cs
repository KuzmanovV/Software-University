using System;

namespace _5.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            int result = DateModifier.GetDiff(startDate, endDate);
            Console.WriteLine(result);
        }
    }
}
