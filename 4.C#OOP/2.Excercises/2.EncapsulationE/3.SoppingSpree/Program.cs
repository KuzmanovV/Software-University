using System;
using System.Collections.Generic;
using System.Transactions;

namespace _3.SoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string,Person>();
            var products = new Dictionary<string,Product>();
            
            try
            {
                people = ReadPeople();
                products = ReadProducts();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmd = command.Split(" ");
                try
                {
                    people[cmd[0]].AddProduct(products[cmd[1]]);
                    Console.WriteLine($"{cmd[0]} bought {cmd[1]}");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var item in people.Values)
            {
                Console.WriteLine(item);
            }
        }

        private static Dictionary<string, Product> ReadProducts()
        {
            var result = new Dictionary<string, Product>();
            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var productParts = part.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = productParts[0];
                var cost = decimal.Parse(productParts[1]);
                result[name] = new Product(name, cost);
            }

            return result;
        }

        private static Dictionary<string, Person> ReadPeople()
        {
            var result = new Dictionary<string, Person>();
            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var personParts = part.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = personParts[0];
                var money = decimal.Parse(personParts[1]);
                result[name] = new Person(name, money);
            }

            return result;
        }
    }
}
