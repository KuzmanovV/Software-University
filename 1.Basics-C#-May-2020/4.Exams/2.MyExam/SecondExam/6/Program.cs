using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първоначално от конзолата се прочита броя на авиокомпаниите – цяло число в интервала[1… 20]
            //След това за всяка авиокомпания се прочита:
            //•	Името на авиокомпанията – текст
            //•	До получаване на командата "Finish" се чете:
            //o Брой пътници на полет  – цяло число в интервала[1... 360]

            int companies = int.Parse(Console.ReadLine());
            double mostAv = 0;
            string mostComp = "";

            for (int i = 1; i <= companies; i++)
            {
                string name = Console.ReadLine();
                string passangersPerFlight = Console.ReadLine();
                int flights = 0;
                double total = 0;

                while (passangersPerFlight!="Finish")
                {
                    total += int.Parse(passangersPerFlight);
                    flights++;
                    passangersPerFlight = Console.ReadLine();
                }

                double output = Math.Floor(total / flights);
                Console.WriteLine($"{name}: {output} passengers.");

                if (output>mostAv)
                {
                    mostAv = output;
                    mostComp = name;
                }
            }
            Console.WriteLine($"{mostComp} has most passengers per flight: {mostAv}");

            //След като излетят всички полети на всички авиокомпании се отпечатва един ред:
            //•	""

        }
    }
}
