using System;

namespace _1.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine())!= "Generate")
            {
                string[] cmd = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "Contains":
                        string substring = cmd[1];

                        if (input.Contains(substring))
                        {
                            Console.WriteLine($"{input} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string letterCase = cmd[1];
                        int start = int.Parse(cmd[2]);
                        int end = int.Parse(cmd[3]);
                        string sub = input.Substring(start, end - start);
                        
                        switch (letterCase)
                        {
                            case "Upper":
                                input = input.Substring(0, start) + sub.ToUpper() + input.Substring(end);
                                break;
                            case "Lower":
                                input = input.Substring(0, start) + sub.ToLower() + input.Substring(end);
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine(input);
                        break;
                    case "Slice":
                        start = int.Parse(cmd[1]);
                        end = int.Parse(cmd[2]);
                        input = input.Remove(start, end - start);
                        Console.WriteLine(input);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
