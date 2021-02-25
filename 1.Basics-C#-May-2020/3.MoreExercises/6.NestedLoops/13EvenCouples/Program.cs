using System;

namespace _13EvenCouples
{
    class Program
    {
        static void Main(string[] args)
        {
            int ab = int.Parse(Console.ReadLine());
            int cd = int.Parse(Console.ReadLine());
            int dif1 = int.Parse(Console.ReadLine());
            int dif2 = int.Parse(Console.ReadLine());

            for (int i = ab; i <= ab+dif1; i++)
            {
                for (int j = cd; j <= cd+dif2; j++)
                {
                    bool isPrime = true;
                    
                    for (int k = 2; k < j/2; k++)
                    {
                        if (j%k==0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    for (int l = 2; l < i/2; l++)
                    {
                        if (i%l==0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                    Console.WriteLine($"{i}{j}");
                    }
                }
            }

        }
    }
}
