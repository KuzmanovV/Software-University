using System;
using System.Collections.Generic;
using System.Linq;


namespace _10ExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string command;

            while ((command = Console.ReadLine())!= "exam finished")
            {
                string[] cmd = command.Split('-');

                if (cmd.Length>2)
                {
                    if (!participants.ContainsKey(cmd[0]))
                    {
                        participants.Add(cmd[0], int.Parse(cmd[2]));
                    }
                    else
                    {
                        if (int.Parse(cmd[2])>participants[cmd[0]])
                        {
                            participants[cmd[0]] = int.Parse(cmd[2]);
                        }
                    }

                    if (!submissions.ContainsKey(cmd[1]))
                    {
                        submissions.Add(cmd[1], 0);
                    }

                    submissions[cmd[1]]++;
                }
                else
                {
                    participants.Remove(cmd[0]);
                }
            }

            Console.WriteLine("Results:");

            foreach (var item in participants.OrderByDescending(x=>x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in submissions.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
