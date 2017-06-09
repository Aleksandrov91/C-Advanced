using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Parking_System
{
    class ParkingSystem
    {
        static void Main()
        {
            var parkingSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var parking = new Dictionary<int, HashSet<int>>();

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var lineArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var entryRow = lineArgs[0];
                var parkingRow = lineArgs[1];
                var parkingCol = lineArgs[2];
                var parkingIsFull = false;
                var distance = Math.Abs(entryRow - parkingRow) + 1;

                if (IsEmpty(parking, parkingRow, parkingCol))
                {
                    distance += parkingCol;
                }
                else
                {
                    for (int i = 1; i < parkingSize[1]; i++)
                    {
                        if (parkingCol - i > 0 && IsEmpty(parking, parkingRow, parkingCol - i))
                        {
                            distance += parkingCol - i;
                            parkingIsFull = false;
                            break;
                        }
                        else if (parkingCol + i < parkingSize[1] && IsEmpty(parking, parkingRow, parkingCol + i))
                        {
                            distance += parkingCol + i;
                            parkingIsFull = false;
                            break;
                        }

                        parkingIsFull = true;
                    }
                }

                if (parkingIsFull)
                {
                    Console.WriteLine($"Row {parkingRow} full");
                }
                else
                {
                    Console.WriteLine(distance);
                }

                input = Console.ReadLine();
            }
        }

        private static bool IsEmpty(Dictionary<int, HashSet<int>> parking, int parkingRow, int parkingCol)
        {
            if (parking.ContainsKey(parkingRow))
            {
                if (parking[parkingRow].Contains(parkingCol))
                {
                    return false;
                }
                else
                {
                    parking[parkingRow].Add(parkingCol);
                }
            }
            else if (!parking.ContainsKey(parkingRow))
            {
                parking[parkingRow] = new HashSet<int>() { parkingCol };
            }

            return true;
        }
    }
}
