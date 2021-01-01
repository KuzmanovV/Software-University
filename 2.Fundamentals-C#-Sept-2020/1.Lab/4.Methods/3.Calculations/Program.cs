using System;

namespace _3.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add": Adding(firstNumber, secondNumber); break;
                case "multiply": Multiplying(firstNumber, secondNumber); break;
                case "subtract": Subtracting(firstNumber, secondNumber); break;
                case "divide": Dividing(firstNumber, secondNumber); break;
            }
        }

        static void Adding(double fNumber, double sNumber)
        {
            Console.WriteLine(fNumber + sNumber);
        }
        static void Multiplying(double fNumber, double sNumber)
        {
            Console.WriteLine(fNumber * sNumber);
        }
        static void Subtracting(double fNumber, double sNumber)
        {
            Console.WriteLine(fNumber - sNumber);
        }
        static void Dividing(double fNumber, double sNumber)
        {
            Console.WriteLine(fNumber / sNumber);
        }
    }
}
