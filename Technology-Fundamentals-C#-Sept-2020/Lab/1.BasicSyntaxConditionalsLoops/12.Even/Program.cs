using System;

namespace _12.Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 0;
            var number = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                check = number % 2;
                if (check != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
            } while (check != 0);

            Console.WriteLine($"The number is: {Math.Abs(number)}");
      
        }
}
}
