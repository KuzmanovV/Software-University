using System;
using System.Collections.Generic;
using _7.MilitatyElite.Contracts;
using _7.MilitatyElite.Enums;
using _7.MilitatyElite.Models;

namespace _7.MilitatyElite
{
    public class StatrtUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, ISoldier> soldiersById = new Dictionary<string, ISoldier>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                var parts = line.Split();
                var type = parts[0];
                var id = parts[1];
                var firstName = parts[2];
                var lastName = parts[3];

                if (type == nameof(Private))
                {
                    var salary = decimal.Parse(parts[4]);
                    soldiersById[id] = new Private(id, firstName, lastName, salary);
                }
                else if (type == nameof(LieutenantGeneral))
                {
                    var salary = decimal.Parse(parts[4]);
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < parts.Length; i++)
                    {
                        var privateId = parts[i];
                        lieutenantGeneral.AddPrivates((IPrivate)soldiersById[privateId]);
                    }

                    soldiersById[id] = (ISoldier)lieutenantGeneral;
                }
                else if (type == nameof(Engineer))
                {
                    if (!Enum.TryParse(parts[5], out Corps corps))
                    {
                        continue;
                    }

                    var salary = decimal.Parse(parts[4]);
                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < parts.Length; i += 2)
                    {
                        var partName = parts[i];
                        var hoursWorked = int.Parse(parts[i + 1]);
                        engineer.AddRepair(new Repair(partName, hoursWorked));
                    }

                    soldiersById[id] = engineer;
                }
                else if (type == nameof(Commando))
                {
                    if (!Enum.TryParse(parts[5], out Corps corps))
                    {
                        continue;
                    }

                    var salary = decimal.Parse(parts[4]);
                    ICommando commando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < parts.Length; i += 2)
                    {
                        var codeName = parts[i];

                        if (Enum.TryParse(parts[i + 1], out State state))
                        {
                            commando.AddMission(new Mission(codeName, state));
                        }
                    }

                    soldiersById[id] = commando;
                }
                else if (type == nameof(Spy))
                {
                    var codeNumber = int.Parse(parts[4]);
                    soldiersById[id] = new Spy(id, firstName, lastName, codeNumber);
                }

            }

            foreach (var soldier in soldiersById)
            {
                Console.WriteLine(soldier.Value);
            }
        }
    }
}
