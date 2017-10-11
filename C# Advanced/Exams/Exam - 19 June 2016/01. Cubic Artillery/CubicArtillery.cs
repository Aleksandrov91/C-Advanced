using System;
using System.Collections.Generic;

namespace _01.Cubic_Artillery
{
    public class CubicArtillery
    {
        public static void Main()
        {
            var bunkersCapacity = int.Parse(Console.ReadLine());
            var bunkersWeapons = new Dictionary<string, Queue<int>>();
            var bunkersLoad = new Dictionary<string, int>();

            var inputLine = Console.ReadLine();
            while (inputLine != "Bunker Revision")
            {
                var tokens = inputLine.Split(' ');

                foreach (var token in tokens)
                {
                    int weapon;
                    var isDigit = int.TryParse(token, out weapon);

                    if (!isDigit)
                    {
                        bunkersWeapons.Add(token, new Queue<int>());
                        bunkersLoad.Add(token, 0);
                    }
                    else
                    {
                        foreach (var bunker in bunkersWeapons)
                        {
                            if (bunkersLoad[bunker.Key] + weapon > bunkersCapacity && bunkersWeapons.Count > 1)
                            {
                                PrintBunker();
                                continue;
                            }

                            if (weapon > bunkersCapacity)
                            {
                                break;
                            }

                            bunkersWeapons[bunker.Key].Enqueue(weapon);
                            bunkersLoad[bunker.Key] += weapon;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
