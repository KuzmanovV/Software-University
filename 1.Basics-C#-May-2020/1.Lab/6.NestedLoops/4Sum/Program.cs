using System;

namespace _4Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int combination = 0;
            bool found = false;

            for (int i = start; i <= end ; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combination++;
                    
                    if (i+j==magic)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {i + j})");
                        found = true;
                        break;
                    }
                }
                
                if (found)
                    {
                        break;
                    }
            }


            if (!found)
            {
Console.WriteLine($"{combination} combinations - neither equals {magic}");
            }
            
            
        }
    }
}
