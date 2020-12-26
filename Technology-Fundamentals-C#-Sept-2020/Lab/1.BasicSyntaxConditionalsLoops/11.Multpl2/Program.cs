using System;

namespace _11.Multpl2
{
    class Program
    {
        static void Main(string[] args)
        {
            var theInteger = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger*times}");
            }
            else
            {
                for (int i = times; i <= 10; i++)
                {
                Console.WriteLine($"{theInteger} X {i} = {theInteger*i}");
                }
            }

        }
    }
}
