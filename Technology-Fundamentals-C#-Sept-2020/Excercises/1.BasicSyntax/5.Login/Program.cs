using System;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = Console.ReadLine();
            string password = "";
            string tried = Console.ReadLine();
            int counter = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            while (true)
            {

                if (tried != password)
                {
                    if (counter == 3)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }

                tried = Console.ReadLine();
            }
        }
    }
}
