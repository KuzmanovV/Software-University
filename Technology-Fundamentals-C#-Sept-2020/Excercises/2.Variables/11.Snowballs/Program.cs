using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());

            BigInteger maxValue = 0;
            byte maxQty = 0;
            int maxSnow = 0;
            short maxTime = 0;

            for (int i = 0; i < balls; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                short time = short.Parse(Console.ReadLine());
                byte qty = byte.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snow / time, qty);

                if (value>maxValue)
                {
                    maxValue = value;
                    maxQty = qty;
                    maxSnow = snow;
                    maxTime = time;
                }
            }
            
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQty})");
        }
    }
}
