using System;

namespace skiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidayDays = int.Parse(Console.ReadLine());
            string guestRoomTipe = Console.ReadLine();
            string assessment = Console.ReadLine();


            double roomPrise = 0.0;

            if (holidayDays < 10)
            {
                if (assessment == "positive")
                {

                    if (guestRoomTipe == "room for one person")
                    {
                        roomPrise = (holidayDays - 1) * 18.00;
                    }
                    else if (guestRoomTipe == "apartment")
                    {
                        roomPrise = ((holidayDays - 1) * 25.00) * 0.70;
                    }
                    else if (guestRoomTipe == "president apartment")
                    {
                        roomPrise = ((holidayDays - 1) * 35) * 0.90;
                    }

                    Console.WriteLine($"{(roomPrise * 1.25):f2}");
                }
                else
                {
                    Console.WriteLine($"{(roomPrise * 0.90):f2}");
                }
            }
            else if (holidayDays >= 10 && holidayDays <= 15)
            {
                if (assessment == "positive")
                {
                    if (guestRoomTipe == "room for one person")
                    {
                        roomPrise = (holidayDays - 1) * 18.00;
                    }
                    else if (guestRoomTipe == "apartment")
                    {
                        roomPrise = ((holidayDays - 1) * 25) * 0.65;
                    }
                    else if (guestRoomTipe == "president apartment")
                    {
                        roomPrise = ((holidayDays - 1) * 35) * 0.85;
                    }
                    Console.WriteLine($"{(roomPrise * 1.25):f2}");
                }
                else
                {
                    Console.WriteLine($"{(roomPrise * 0.90):f2}");
                }

            }
            else if (holidayDays > 15)
            {
                if (assessment == "positive")
                {
                    if (guestRoomTipe == "room for one person")
                    {
                        roomPrise = (holidayDays - 1) * 18.00;
                    }
                    else if (guestRoomTipe == "apartment")
                    {
                        roomPrise = ((holidayDays - 1) * 25) * 0.50;
                    }
                    else if (guestRoomTipe == "president apartment")
                    {
                        roomPrise = ((holidayDays - 1) * 35) * 0.80;
                    }
                    Console.WriteLine($"{(roomPrise * 1.25):f2}");
                }
                else
                {
                    Console.WriteLine($"{(roomPrise * 0.90):f2}");
                }
            }
        }
    }
}