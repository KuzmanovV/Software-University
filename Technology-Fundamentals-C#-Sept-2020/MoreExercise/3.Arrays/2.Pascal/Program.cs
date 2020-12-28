using System;

namespace _2.Pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

int[] arrF = new int[1];

            for (int i = 0; i < n; i++)
            {
                
                int[] arrS= new int[i+1];
                int k = 0;

                for (int j = 0; j < i; j+=2)
                {
                    arrF[j] = j;
                    arrS[j] = arrF[j] + arrF[k];
                    k = j++;
                }

                Console.WriteLine(string.Join(" ", arrF));
                Console.WriteLine(string.Join(" ", arrS));
            }
        }
    }
}
