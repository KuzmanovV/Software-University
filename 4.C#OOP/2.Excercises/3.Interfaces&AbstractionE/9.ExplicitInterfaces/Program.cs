using System;

namespace _9.ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine();

                if (line=="End")
                {
                    break;
                }

                var parts = line.Split();
                IPerson citizen = new Citizen(parts[0],parts[1], int.Parse(parts[2]));
                IResident citizen1 = new Citizen(parts[0],parts[1], int.Parse(parts[2]));
                Console.WriteLine(citizen.GetName());
                Console.WriteLine(citizen1.GetName());
            }
        }
    }
}
