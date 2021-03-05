using System;
using System.Collections.Generic;

namespace _4.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> detained = new List<int>();

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd=="End")
                {
                    break;
                }

                string[] parts = cmd.Split();

                if (parts.Length==2)
                {
                    IMachine suspect = new Robot(parts[0],int.Parse(parts[1]));
                }
            }
        }
    }
}
