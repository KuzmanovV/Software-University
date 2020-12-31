using System;
using System.Linq;
using System.Text;

namespace _3.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input;


            while ((input = Console.ReadLine()) != "find")
            {
                int counter = 0;
                StringBuilder keyd = new StringBuilder();

                foreach (var ch in input)
                {
                    if (counter > key.Length - 1)
                    {
                        counter = 0;
                    }
                    keyd.Append((char)(ch - key[counter]));
                    counter++;
                }

                string output = keyd.ToString();
                int index = output.IndexOf('&');
                int indexEnd = output.LastIndexOf('&');
                string type = output.Substring(index + 1, indexEnd - index - 1);

                int index1 = output.IndexOf('<');
                int indexEnd1 = output.IndexOf('>');
                string coord = output.Substring(index1 + 1, indexEnd1 - index1 - 1);

                Console.WriteLine($"Found {type} at {coord}");
            }
        }
    }
}
