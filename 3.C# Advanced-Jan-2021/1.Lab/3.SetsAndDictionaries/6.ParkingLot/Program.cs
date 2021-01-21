using System;
using System.Collections.Generic;

namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            string command;

            while ((command = Console.ReadLine())!="END")
            {
                string[] cmd = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = cmd[0];
                string plate = cmd[1];

                if (direction=="IN")
                {
                    parking.Add(plate);
                }
                else
                {
                    parking.Remove(plate);
                }
            }

            if (parking.Count!=0)
            {
                foreach (var plate in parking)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
