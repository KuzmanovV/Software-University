using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthdatables = new List<IBirthable>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                var parts = line.Split();
                if (parts[0] == "Citizen")
                {
                    var name = parts[1];
                    var age = int.Parse(parts[2]);
                    var id = parts[3];
                    var birthdate = parts[4];

                    birthdatables.Add(new Citizen(name, age, id,birthdate));
                }
                else if(parts[0] == "Pet")
                {
                    var name = parts[1];
                    var birthdate = parts[2];

                    birthdatables.Add(new Pet(name, birthdate));
                }
            }

            var filter = Console.ReadLine();
            List<IBirthable> filteredbirtables = birthdatables.Where(i => i.Birthdate.EndsWith(filter)).ToList();

            foreach (var filteredBirthable in filteredbirtables)
            {
                Console.WriteLine(filteredBirthable.Birthdate);
            }
        }
    }
}
