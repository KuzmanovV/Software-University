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
            List<string> filters = new List<string>();

            Func<string, string, bool> startsWith = (g, letters) => g.StartsWith(letters);
            Func<string, string, bool> endsWith = (guest, letters) => guest.EndsWith(letters);
            Func<string, int, bool> checkLength = (guest, number) => guest.Length == number;
            Func<string, string, bool> contains = (guest, letters) => guest.Contains(letters);
            
            string command;
            while ((command = Console.ReadLine())!="Print")
            {
                string[] cmd = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                
                if (cmd[0]=="Add filter")
                {
                    filters.Add(string.Join(";", cmd[1], cmd[2]));
                }
                else
                {
                    filters.Remove(string.Join(";", cmd[1], cmd[2]));
                }
            }

            for (int i = 0; i < filters.Count; i++)
            {
                string[] cmd = filters[i].Split(";");

                switch (cmd[0])
                {
                    case "Starts with":
                        guests = guests.Where(guest => !startsWith(guest, cmd[1])).ToList();
                        break;
                    case "Ends with":
                        guests = guests.Where(guest => !endsWith(guest, cmd[1])).ToList();
                        break;
                    case "Contains":
                        guests = guests.Where(guest => !contains(guest, cmd[1])).ToList();
                        break;
                    case "Length":
                        guests = guests.Where(guest => !checkLength(guest, int.Parse(cmd[1]))).ToList();
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", guests));
        }
    }
}
