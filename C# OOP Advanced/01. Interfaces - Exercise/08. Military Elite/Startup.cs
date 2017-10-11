namespace _08.Military_Elite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using Entities.Utils;
    using Interfaces;

    public class Startup
    {
        private static IList<ISoldier> army;

        public static void Main()
        {
            army = new List<ISoldier>();
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var inputArgs = inputLine.Split(' ').ToList();

                var soldierType = inputArgs[0];
                inputArgs.Remove(soldierType);

                try
                {
                    switch (soldierType)
                    {
                        case "Private":
                            army.Add(new Private(inputArgs[0], inputArgs[1], inputArgs[2], double.Parse(inputArgs[3])));
                            break;
                        case "LeutenantGeneral":
                            var soldiers = AddSoldiers(inputArgs.Skip(4).ToList());
                            army.Add(new LeutenantGeneral(inputArgs[0], inputArgs[1], inputArgs[2], double.Parse(inputArgs[3]), soldiers));
                            break;
                        case "Engineer":
                            var parts = CreateParts(inputArgs.Skip(5).ToList());
                            army.Add(new Engineer(inputArgs[0], inputArgs[1], inputArgs[2], double.Parse(inputArgs[3]), inputArgs[4], parts));
                            break;
                        case "Commando":
                            var missions = CreateMission(inputArgs.Skip(5).ToList());
                            army.Add(new Commando(inputArgs[0], inputArgs[1], inputArgs[2], double.Parse(inputArgs[3]), inputArgs[4], missions));
                            break;
                        case "Spy":
                            army.Add(new Spy(inputArgs[0], inputArgs[1], inputArgs[2], int.Parse(inputArgs[3])));
                            break;
                    }
                }
                catch (ArgumentException)
                {
                }

                inputLine = Console.ReadLine();
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        private static List<IMission> CreateMission(List<string> missionArgs)
        {
            var missions = new List<IMission>();

            for (int i = 0; i < missionArgs.Count - 1; i++)
            {
                if (missionArgs[i + 1] != "inProgress" && missionArgs[i + 1] != "Finished")
                {
                    continue;
                }

                missions.Add(new Mission(missionArgs[i], missionArgs[i + 1]));
            }

            return missions;
        }

        private static List<IRepairable> CreateParts(List<string> parts)
        {
            var createdParts = new List<IRepairable>();

            for (int i = 0; i < parts.Count - 1; i += 2)
            {
                createdParts.Add(new Repair(parts[i], int.Parse(parts[i + 1])));
            }

            return createdParts;
        }

        private static List<ISoldier> AddSoldiers(List<string> soldiersId)
        {
            var soldiers = new List<ISoldier>();

            foreach (var soldierId in soldiersId)
            {
                if (army.Any(s => s.Id == soldierId))
                {
                    soldiers.Add(army.First(s => s.Id == soldierId));
                }
            }

            return soldiers;
        }
    }
}
