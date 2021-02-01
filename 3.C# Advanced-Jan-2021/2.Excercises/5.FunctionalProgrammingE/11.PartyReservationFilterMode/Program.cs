using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterMode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();

            string command;
            while ((command = Console.ReadLine())!="Print")
            {
                string[] cmd = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                cmd[1] = 
            }
        }
    }
}
