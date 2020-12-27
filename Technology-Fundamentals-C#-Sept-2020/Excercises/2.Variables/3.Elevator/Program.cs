using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleToTransport = int.Parse(Console.ReadLine());
            int peopleCapacity = int.Parse(Console.ReadLine());
            int output = 0;

            while (peopleToTransport > 0)
            {
                peopleToTransport -= peopleCapacity;
                output++;
            }
            
            Console.WriteLine(output);
        }
    }
}
