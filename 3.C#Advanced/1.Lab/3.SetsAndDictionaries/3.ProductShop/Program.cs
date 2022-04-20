using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, Dictionary<string, double>> output = new Dictionary<string, Dictionary<string, double>>();

            while ((input=Console.ReadLine())!= "Revision")
            {
                string[] cmd = input.Split(", ");

                if (!output.ContainsKey(cmd[0]))
                {
                    output.Add(cmd[0],new Dictionary<string, double>());
                    output[cmd[0]][cmd[1]] = double.Parse(cmd[2]);
                }
                else
                {
                    output[cmd[0]][cmd[1]] = double.Parse(cmd[2]);
                }
            }

            foreach (var item in output.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
