using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string big = Console.ReadLine().TrimStart('0');
            int single = int.Parse(Console.ReadLine());

            int cut = 0;

            StringBuilder output = new StringBuilder();

            if (single > 0)
            {
                foreach (char ch in big.Reverse())
                {
                    int mult = single * int.Parse(ch.ToString()) + cut;

                    int rem = mult % 10;
                    cut = mult / 10;

                    output.Insert(0, rem);
                }

                if (cut > 0)
                {
                    output.Insert(0, cut);
                }

                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("0");
                
            }
        }
    }
}
