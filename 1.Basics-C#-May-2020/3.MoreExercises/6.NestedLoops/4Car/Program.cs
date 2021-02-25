using System;

namespace _4Car
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Първи ред - едноцифрено число - началото на интервала – цяло число в интервала[1…9]
            //            2.Втори ред - едноцифрено число - края на интервала – цяло число в интервала[1…9]

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        for (int l = start; l <= end; l++)
                        {
                            if ((i%2==0 && l%2!=0) || (i % 2 != 0 && l % 2 == 0))
                            {
                                if (i>l && (j+k)%2==0)
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
}
