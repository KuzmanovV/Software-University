using System;

namespace _5Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Броя клиенти мъже - цяло число в интервала[1...100]
            //•	Броя клиенти жени - цяло число в интервала[1...100]
            //•	Максималният брой маси - цяло число в интервала[1...100]

            int men = int.Parse(Console.ReadLine());
            int wemen = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int counter = 0;
            bool full = false;

                for (int i = 1; i <= men; i++)
                {
                     for (int j = 1; j <= wemen; j++)
                     {
                            Console.Write($"({i} <-> {j}) ");
                            counter++;
                    
                            if (counter>=tables)
                            {
                        full = true;    
                        break;
                            }
                     }

                     if (full)
                        {
                    break;
                        }
                }
        }
    }
}
