using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	N – цяло число – 0 <= N < M
            //•	M – цяло число – N < M <= 10000
            //•	S – цяло числo – N <= S <= M

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int i = M; i >= N; i--)
            {
                if (i%2==0 && i%3==0)
                {
                    if (i==S)
                    {
                        break;
                    }

                    Console.Write($"{i} ");
                }
            }

        }
    }
}
