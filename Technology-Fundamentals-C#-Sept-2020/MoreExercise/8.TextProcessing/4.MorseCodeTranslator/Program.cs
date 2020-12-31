using System;
using System.Text;

namespace _4.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder output = new StringBuilder();

            foreach (var item in input)
            {
                string[] words = item.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                char letter = ' ';

                foreach (var le in words)
                {
                    switch (le)
                    {
                        case ".-": letter = 'A'; break;
                        case "-...": letter = 'B'; break;
                        case "-.-.": letter = 'C'; break;
                        case "-..": letter = 'D'; break;
                        case ".": letter = 'E'; break;
                        case "..-.": letter = 'F'; break;
                        case "--.": letter = 'G'; break;
                        case "....": letter = 'H'; break;
                        case "..": letter = 'I'; break;
                        case ".---": letter = 'J'; break;
                        case "-.-": letter = 'K'; break;
                        case ".-..": letter = 'L'; break;
                        case "--": letter = 'M'; break;
                        case "-.": letter = 'N'; break;
                        case "---": letter = 'O'; break;
                        case ".--.": letter = 'P'; break;
                        case "--.-": letter = 'Q'; break;
                        case ".-.": letter = 'R'; break;
                        case "...": letter = 'S'; break;
                        case "-": letter = 'T'; break;
                        case "..-": letter = 'U'; break;
                        case "...-": letter = 'V'; break;
                        case ".--": letter = 'W'; break;
                        case "-..-": letter = 'X'; break;
                        case "-.--": letter = 'Y'; break;
                        case "--..": letter = 'Z'; break;
                    }

                    output.Append(letter);
                }

                output.Append(' ');
            }

            Console.WriteLine(output);
        }
    }
}
