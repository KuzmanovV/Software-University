using System;
using System.Collections.Generic;
using System.Linq;

namespace MEAssArr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwords = new Dictionary<string, string>();
            Dictionary<string, int> results = new Dictionary<string, int>();
            SortedDictionary<string, Dictionary<string, int>> submissions
                = new SortedDictionary<string, Dictionary<string, int>>();

            string password;

            while ((password = Console.ReadLine()) != "end of contests")
            {
                string[] cmd = password.Split(':', StringSplitOptions.RemoveEmptyEntries);

                passwords.Add(cmd[0], cmd[1]);
            }

            string submission;

            while ((submission = Console.ReadLine()) != "end of submissions")
            {
                string[] cmd = submission.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = cmd[0];
                string pass = cmd[1];
                string username = cmd[2];
                int points = int.Parse(cmd[3]);

                if (passwords.ContainsKey(contest) && passwords[contest] == pass)
                {
                    if (!submissions.ContainsKey(username))
                    {
                        submissions[username] = new Dictionary<string, int>();
                        submissions[username][contest] = points;
                        results[username] = points;
                    }
                    else
                    {
                        if (!submissions[username].ContainsKey(contest))
                        {
                            submissions[username][contest] = points;
                            results[username] += points;
                        }
                        else
                        {
                            submissions[username][contest] = Math.Max(points, submissions[username][contest]);
                            if (points > submissions[username][contest])
                            {
                                results[username] += points;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Best candidate is {results.OrderByDescending(x => x.Value).First().Key}" +
                $" with total {results.Values.Max()} points.\nRanking: ");

            foreach (var item in submissions.OrderBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var con in submissions[item.Key].OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {con.Key} -> {con.Value}");
                }
            }
        }
    }
}

