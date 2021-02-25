using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int nonPrimeSum = 0;
            int primeSum = 0;
            bool prime = true;

            while (n!="stop")
            {
                int nn = int.Parse(n);

                if (nn<0)
                {
                    Console.WriteLine("Number is negative.");
                    n = Console.ReadLine();
                }
                else
                {
                    for (int i = 2; i < nn; i++)
                    {
                        if (nn%i==0)
                        {
                            nonPrimeSum += nn;
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                    {
                        primeSum += nn;
                        
                    }
                    prime = true;
                    n = Console.ReadLine();
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
