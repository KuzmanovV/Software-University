using System;
using System.Collections.Generic;

namespace _7.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string command;
            while ((command=Console.ReadLine())!="PARTY")
            {
                if (Char.IsDigit(command[0]))
                {
                    vip.Add(command);
                }
                else
                {
                    regular.Add(command);
                }
            }
            
            while ((command=Console.ReadLine())!="END")
            {
                if (vip.Contains(command))
                {
                    vip.Remove(command);
                }
                else
                {
                    regular.Remove(command);
                }
            }

            Console.WriteLine(vip.Count+regular.Count);

            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }
    }
}
