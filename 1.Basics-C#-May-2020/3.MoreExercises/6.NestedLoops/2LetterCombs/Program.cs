using System;

namespace _2LetterCombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ред 1.Малка буква от английската азбука за начало на интервала – от ‘a’ до ‚z’.
            //Ред 2.Малка буква от английската азбука за край на интервала  – от първата буква до ‚z’.
            //Ред 3.Малка буква от английската азбука – от ‘a’ до ‚z’ – като комбинациите съдържащи тази буквата се пропускат.

            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char excl = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i!=excl && j!=excl && k!=excl)
                        {
                            counter++;
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
