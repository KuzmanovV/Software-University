using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        }
    }
}
