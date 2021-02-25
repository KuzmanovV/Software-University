using System;

namespace ForCicle_Excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/

            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                int cNum = int.Parse(Console.ReadLine());

                if (cNum<200)
                {
                    p1 ++;
                    
                }
                else if (cNum>=200 && cNum<400)
                {
                    p2 ++;
                    
                }
                else if (cNum>=400 && cNum<600)
                {
                    p3 ++;
                    
                }
                else if (cNum>=600 && cNum<800)
                {
                    p4 ++;
                }
                else
                {
                    p5 ++;
                }
            }

            Console.WriteLine($"{p1/n*100:f2}%");
            Console.WriteLine($"{p2/n*100:f2}%");
            Console.WriteLine($"{p3/n*100:f2}%");
            Console.WriteLine($"{p4/n*100:f2}%");
            Console.WriteLine($"{p5/n*100:f2}%");

        }
    }
}
