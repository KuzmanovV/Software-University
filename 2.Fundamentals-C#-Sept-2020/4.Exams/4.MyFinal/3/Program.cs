using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> mail = new Dictionary<string, List<int>>();

            int max = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] cmd = command.Split("=", StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "Add":
                        string username = cmd[1];
                        int sent = int.Parse(cmd[2]);
                        int received = int.Parse(cmd[3]);

                        if (!mail.ContainsKey(username))
                        {
                            mail.Add(username, new List<int>() { sent, received });
                        }
                        break;
                    case "Message":
                        string sender = cmd[1];
                        string receiver = cmd[2];

                        if (mail.ContainsKey(sender) && mail.ContainsKey(receiver))
                        {
                            mail[sender][0]++;
                            mail[receiver][1]++;

                            if (mail[sender][0]+ mail[sender][1] == max)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                mail.Remove(sender);
                            }

                            if (mail[receiver][1]+ mail[receiver][0] == max)
                            {
                                Console.WriteLine($"{receiver} reached the capacity!");
                                mail.Remove(receiver);
                            }
                        }
                        break;
                    case "Empty":
                        username = cmd[1];
                        if (username == "All")
                        {
                            Dictionary<string, List<int>> mailNew = new Dictionary<string, List<int>>();

                            //foreach (var item in mail)
                            //{
                            //    mailNew.Add(item.Key, new List<int>() { 0, 0});
                            //}

                            mail = mailNew;

                        }
                        else
                        {
                            if (mail.ContainsKey(username))
                            {
                                mail.Remove(username);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Users count: {mail.Count}");

            foreach (var item in mail.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Sum()}");
            }
        }
    }
}
