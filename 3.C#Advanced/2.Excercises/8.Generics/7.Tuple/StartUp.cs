using System;
using System.Linq;

namespace _7.Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] town = input.Skip(3).ToArray();
            Threeuple<string, string, string> myTuple = new Threeuple<string, string, string>(string.Join(" ", input[0], input[1]), input[2], string.Join(" ", town));

            string[] input2 = Console.ReadLine().Split();
            bool drunk = input2[2] == "drunk";
            Threeuple<string, int, bool> myTuple2 = new Threeuple<string, int, bool>(input2[0], int.Parse(input2[1]), drunk);

            string[] input3 = Console.ReadLine().Split();
            Threeuple<string, double, string> myTuple3 = new Threeuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);

            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple2);
            Console.WriteLine(myTuple3);
        }
    }
}
