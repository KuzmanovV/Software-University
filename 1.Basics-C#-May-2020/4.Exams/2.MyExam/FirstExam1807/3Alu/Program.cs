using System;

namespace _3Alu
{
    class Program
    {
        static void Main(string[] args)
        {
            int alus = int.Parse(Console.ReadLine());
            string kind = Console.ReadLine();
            string delivery = Console.ReadLine();
            double pr = 0.0;

            if (alus<=10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                switch (kind)
                {
                    case "90X130": pr = 110;
                        if (alus>60)
                        {
                            pr *= .92;
                        }
                        else if (alus>30)
                        {
                            pr *= .95;
                        }
                        break;
                    case "100X150": pr = 140;
                        if (alus>80)
                        {
                            pr *= .9;
                        }
                        else if (alus>40)
                        {
                            pr *= .94;
                        }
                        break;
                        case "130X180": pr = 190;
                        if (alus>50)
                        {
                            pr *= .88;
                        }
                        else if (alus>20)
                        {
                            pr *= .93;
                        }
                        break;
                    case "200X300": pr = 250;
                        if (alus>50)
                        {
                            pr *= .86;
                        }
                        else if (alus>25)
                        {
                            pr *= .91;
                        }
                        break;
                }

                double total = alus * pr;
                
                if (delivery== "With delivery")
                {
                    total += 60;
                }
                
                if (alus>99)
                {
                    total *= .96;
                }

                Console.WriteLine($"{total:f2} BGN");
            }

        }
    }
}
