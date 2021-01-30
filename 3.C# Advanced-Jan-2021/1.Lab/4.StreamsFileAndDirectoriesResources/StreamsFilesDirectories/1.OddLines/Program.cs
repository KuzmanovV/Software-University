using System;
using System.IO;

namespace _1.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input1.txt"))
            {
                string currentRow = reader.ReadLine();
                int counterRow = 0;

                while (currentRow != null)
                {

                    if (counterRow%2==1)
                    {
                    Console.WriteLine(currentRow);
                    }

                    currentRow = reader.ReadLine();
                    counterRow++;
                }
            }
        }
    }
}
