using System;

namespace MoreExc
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int newMax = firstNumber;
            int newMiddle = firstNumber;
            int newLast = firstNumber;
            
            if (secondNumber > newMax)
            {
                newMax = secondNumber;
            }

            if (thirdNumber > newMax)
            {
                newMax = thirdNumber;
            }

            if (secondNumber < newLast)
            {
                newLast = secondNumber;
            }
            
            if (thirdNumber < newLast)
            {
                newLast = thirdNumber;
            }

            if (secondNumber != newMax && secondNumber != newLast)
            {
                newMiddle = secondNumber;
            }
            
            if (thirdNumber != newMax && thirdNumber != newLast)
            {
                newMiddle = thirdNumber;
            }

            Console.WriteLine(newMax);
            Console.WriteLine(newMiddle);
            Console.WriteLine(newLast);

        }
    }
}
