using System;

namespace ForCicle_Excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            string output1 = "";
            string output2 = "";

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number>max)
                {
                    max = number;
                }       
            }

            if (max==sum-max)
            {
                output1 = "Yes";
                output2 = $"Sum = {max}";
            }
            else
            {
                output1 = "No";
                output2 = $"Diff = {Math.Abs(max-(sum-max))}";
            }

            Console.WriteLine(output1);
            Console.WriteLine(output2);

            /**/
        }
    }
}
