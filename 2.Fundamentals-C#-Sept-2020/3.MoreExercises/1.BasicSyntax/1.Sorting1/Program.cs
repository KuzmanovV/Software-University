using System;

namespace _1.Sorting1
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggest = int.Parse(Console.ReadLine());
            int middle = int.Parse(Console.ReadLine());
            int smallest = int.Parse(Console.ReadLine());
            int x = 0;

            if (smallest>middle)
            {
                x = middle;
                middle = smallest;
                smallest = x;
            }

            if (middle>biggest)
            {
                x = middle;
                middle = biggest;
                biggest = x;
            }

            if (smallest > middle)
            {
                x = middle;
                middle = smallest;
                smallest = x;
            }

            Console.WriteLine(biggest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);
        }
    }
}
