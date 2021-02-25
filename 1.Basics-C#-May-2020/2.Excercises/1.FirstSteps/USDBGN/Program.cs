using System;

namespace USDBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double inpUSD = double.Parse(Console.ReadLine());
            double resBGN = inpUSD * 1.79549;
            Console.WriteLine(resBGN);

        }
    }
}
