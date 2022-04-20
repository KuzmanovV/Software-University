using System;

namespace _6.TriplesOfLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        int a = 60 + i;
                        Console.Write((char)('a'+i));
                        Console.Write((char)('a'+j));
                        Console.WriteLine((char)('a'+k));

                    }
                }
            }
            
        }
    }
}
