using System;
using System.Linq;

namespace _1.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] token = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                switch (token[0])
                {
                    case "InsertSpace":
                        input = input.Insert(int.Parse(token[1]), " ");
                        Console.WriteLine(input);
                        break;
                    case "Reverse":
                        string substring = token[1];
                        int index = input.IndexOf(substring);

                        if (index>-1)
                        {
                            input = input.Remove(index, token[1].Length);
                            char[] inp = token[1].ToCharArray();
                            Array.Reverse(inp);
                            input += new string(inp);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        
                        break;
                    case "ChangeAll":
                        substring = token[1];
                        string replacement = token[2];
                        input = input.Replace(substring, replacement);
                        Console.WriteLine(input);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
