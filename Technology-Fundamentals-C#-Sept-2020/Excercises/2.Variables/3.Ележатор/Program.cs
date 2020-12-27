using System;

namespace _3.Ележатор
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleToTransport = int.Parse(Console.ReadLine());
            int peopleCapacity = int.Parse(Console.ReadLine());
            int output = 0;

            output = (int)Math.Ceiling((double)peopleToTransport / peopleCapacity);

            Console.WriteLine(output);
        }
    }
}
