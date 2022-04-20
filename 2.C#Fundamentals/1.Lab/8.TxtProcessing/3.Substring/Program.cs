using System;
using System.Linq;

namespace _3.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().ToLower();
            string target = Console.ReadLine();
            //int index = target.IndexOf(key);

            //while (index != -1)
            //{
            //    target = target.Remove(index, key.Length);
            //    index = target.IndexOf(key);

            //}
            while (target.IndexOf(key) != -1)
            {
                target = target.Replace(key, "");
            }

            Console.WriteLine(target);
        }
    }
}
