using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split().ToArray();

            string command;
            while ((command = Console.ReadLine())!="Party!")
            {
                string[] cmd = command.Split();
                
                switch (cmd[0])
                {
                    case "Remove":
                        if (cmd[1]=="StartsWith")
                        {

                        }
                        else if (cmd[1]== "EndsWith ")
                        {

                        }
                        else
                        {

                        }
                            break;
                    case "Double":
                    default:
                        break;
                }
            }
        }
    }
}
