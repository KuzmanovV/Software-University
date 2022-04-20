using System;
using System.Linq;

namespace GenericArrayCreator
{
    public class StartUP
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "pesho");

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
