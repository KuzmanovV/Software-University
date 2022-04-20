using System;

namespace _1.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine())!= "Decode")
            {
                string[] cmd = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "Move":
                        int numLetters = int.Parse(cmd[1]);
                        string first = input.Substring(0, numLetters);
                        input = input.Remove(0, numLetters);
                        input += first;
                        break;
                    case "Insert":
                        int index = int.Parse(cmd[1]);
                        string value = cmd[2];
                        input = input.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string substring = cmd[1];
                        string replacement = cmd[2];
                        input = input.Replace(substring, replacement);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
