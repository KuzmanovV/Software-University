using System;

namespace Telefony
{
    public class StationaryPhone: IPhonable
    {
        public void Call(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}