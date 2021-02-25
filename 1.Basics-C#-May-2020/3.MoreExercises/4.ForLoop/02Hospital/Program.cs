using System;

namespace _02Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            /*На първия ред – периода, за който трябва да направите изчисления. Цяло число в интервала [1 ... 1000]
На следващите редове(равни на броят на дните) – броя пациенти, които пристигат за преглед за текущия ден.
            Цяло число в интервала [0…10 000]*/

            int days = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int doctors = 7;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i%3==0 && treated<untreated)
                {
                    doctors++;
                }

                if (patients>=doctors)
                {
                    treated += doctors;
                    untreated = untreated + patients - doctors;
                }
                else
                {
                    treated += patients;
                }
                
            }

            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
