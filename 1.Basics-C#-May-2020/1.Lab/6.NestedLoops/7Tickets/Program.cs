using System;

namespace _7Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред до получаване на командата "Finish" - име на филма – текст
            //•	На втори ред – свободните места в салона за всяка прожекция – цяло число[1 … 100]
            //•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
            //o Типа на закупения билет - текст(, , "kid")

            string film = Console.ReadLine();
            
            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;


            while (film != "Finish")
            {
                int places = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                int ticketCounter = 0;

                while (ticketType != "End") //до изчерпване на свободните места в залата
                {
                    ticketCounter++;
                    
                    if (ticketType == "student")
                    {
                        studentCounter++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardCounter++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidCounter++;
                    }

                    if (ticketCounter == places)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                Console.WriteLine($"{film} - {100.0 *ticketCounter/places:f2}% full.");
                film = Console.ReadLine();
            }
            int total = studentCounter + standardCounter + kidCounter;
            Console.WriteLine($"Total tickets: {total}");
            Console.WriteLine($"{100.0*studentCounter/total:f2}% student tickets.");
            Console.WriteLine($"{100.0*standardCounter/total:f2}% standard tickets.");
            Console.WriteLine($"{100.0*kidCounter/total:f2}% kids tickets.");
        }
    }
}
