using System;

namespace _5.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte lines = byte.Parse(Console.ReadLine());

            string decrypted = "";

            for (int i = 0; i < lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                decrypted += (char)(letter+key);
            }
            
            Console.WriteLine(decrypted);
        }
    }
}
