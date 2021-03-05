using System;

namespace Telefony
{
    public class Smartphone: IBrowsable, IPhonable
    {
        public void Browse(string site)
        {
            Console.WriteLine($"Browsing: {site}!");
        }

        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}