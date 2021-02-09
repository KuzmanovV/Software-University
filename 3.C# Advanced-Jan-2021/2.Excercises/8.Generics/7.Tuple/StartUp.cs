using System;
using System.Linq;

namespace _7.Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            MyTuple<string, string> myTuple = new MyTuple<string, string>(string.Join(" ", input[0], input[1]), input[2]);

            string[] input2 = Console.ReadLine().Split();
            MyTuple<string, int> myTuple2 = new MyTuple<string, int>(input2[0], int.Parse(input2[1]));

            string[] input3 = Console.ReadLine().Split();
            MyTuple<int, double> myTuple3 = new MyTuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));

            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple2);
            Console.WriteLine(myTuple3);
        }
    }
}
