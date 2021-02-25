using System;

namespace NestedLoops_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currNum = 1;
            bool ready = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write($"{currNum} ");
                    currNum++;

                    if (currNum>n)
                    {
                        ready = true;
                        break;
                    }
                }

                if (ready)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
