using System;
using System.Collections.Generic;

namespace _1.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> users = new HashSet<string>();
            
            for (int i = 0; i < n; i++)
            {
                users.Add(Console.ReadLine());
            }

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
