using System;
using System.Collections.Generic;

namespace _3.SoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            string[] secondLine = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);

            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            
            for (int i = 0; i < firstLine.Length; i++)
            {
                string[] cmd = firstLine[i].Split("=");
                Person person = new Person(cmd[0],int.Parse(cmd[1]));
                persons.Add(person);
            }
            for (int i = 0; i < secondLine.Length; i++)
            {
                string[] cmd = firstLine[i].Split("=");
                Product product= new Product(cmd[0], int.Parse(cmd[1]));
                products.Add(product);
            }

            string command;
            while ((command=Console.ReadLine())!="END")
            {
                string[] cmd = command.Split(" ");
                persons.IndexOf(cmd[0]);
            }
        }
    }
}
