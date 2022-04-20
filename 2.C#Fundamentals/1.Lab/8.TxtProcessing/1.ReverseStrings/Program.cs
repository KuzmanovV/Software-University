using System;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "end")
            {
                //string reversed = "";
                    char[] reversed = word.ToCharArray();

                //for (int i = 0; i < word.Length; i++)
                {
                    //reversed += word[word.Length - 1 - i];
                }
                Array.Reverse(reversed);
                Console.WriteLine($"{word} = {string.Join("", reversed)}");
            }
        }
    }
}
