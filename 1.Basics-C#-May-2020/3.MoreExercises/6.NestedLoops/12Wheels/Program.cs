using System;

namespace _12Wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;

            for (int a = 1; a < 9; a++)
            {
                for (int b = 2; b < 10; b++)
                {
                    for (int c = 2; c < 10; c++)
                    {
                        for (int d = 1; d < 9; d++)
                        {
                            if (M==(a*b+c*d) && a<b && c>d)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                            }

                            if (counter==4)
                            {
                                e = a;
                                f = b;
                                g = c;
                                h = d;
                                counter++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            if (counter<4)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine($"Password: {e}{f}{g}{h}");
            }
        }
    }
}
