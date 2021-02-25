using System;

namespace _08Weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            switch (day)
            {
                case "Wednesday":
                case "Thursday": Console.WriteLine(14); break;
                case "Saturday":
                case "Sunday": Console.WriteLine(16); break;
                default: Console.WriteLine(12);
                    break;
            }
        }
    }
}
