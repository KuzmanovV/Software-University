using System;

namespace _6Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string abcd = Console.ReadLine();
            string efgh = Console.ReadLine();
            
            int a = int.Parse(abcd[0].ToString());
            int b = int.Parse(abcd[1].ToString());
            int c = int.Parse(abcd[2].ToString());
            int d = int.Parse(abcd[3].ToString());
            
            int e = int.Parse(efgh[0].ToString());
            int f = int.Parse(efgh[1].ToString());
            int g = int.Parse(efgh[2].ToString());
            int h = int.Parse(efgh[3].ToString());

            for (int i = a; i <= e; i++)
            {
                for (int j = b; j <= f; j++)
                {
                    for (int k = c; k <= g; k++)
                    {
                        for (int l = d; l <= h; l++)
                        {
                            if (i%2==1 && j%2==1 && k%2==1 && l%2==1)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
