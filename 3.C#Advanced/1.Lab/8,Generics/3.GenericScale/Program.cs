using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> s = new EqualityScale<int>(5, 5);

            bool result = s.AreEqual();

            Console.WriteLine(result);
        }
    }
}
