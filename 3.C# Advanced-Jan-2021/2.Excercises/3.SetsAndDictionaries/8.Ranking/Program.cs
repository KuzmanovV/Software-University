using System;
using System.Linq;
using System.Collections.Generic;

namespace _8.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> results = new SortedDictionary<string, Dictionary<string, int>>();

            string contestInput;
            while ((contestInput = Console.ReadLine()) != "end of contests")
            {
                string[] contestData = contestInput.Split(":", StringSplitOptions.RemoveEmptyEntries);
                contests[contestData[0]] = contestData[1];
            }

            string resultsInput;
            while ((resultsInput = Console.ReadLine()) != "end of submissions")
            {
                string[] resultsData = resultsInput.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = resultsData[0];
                string pass = resultsData[1];
                string intern = resultsData[2];
                int points = int.Parse(resultsData[3]);

                if (contests.ContainsKey(contest) && contests[contest] == pass) //CHECK IF LIGID
                {
                    if (!results.ContainsKey(intern))
                    {
                        results[intern] = new Dictionary<string, int>();
                    }

                    if (!results[intern].ContainsKey(contest) || results[intern][contest] < points)
                    {
                        results[intern][contest] = points;
                    }
                }
            }

            int maxSum = 0;
            string maxIntern = "";
            foreach (var student in results)
            {
                int sum = 0;
                foreach (var contest in results[student.Key])
                {
                    sum += results[student.Key][contest.Key];
                }

                if (sum>maxSum)
                {
                    maxSum = sum;
                    maxIntern = student.Key;
                }
            }
            
            Console.WriteLine($"Best candidate is {maxIntern} with total {maxSum} points.");
            Console.WriteLine("Ranking:");

            foreach (var intern in results)
            {
                Console.WriteLine(intern.Key);

                foreach (var contest in results[intern.Key].OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
