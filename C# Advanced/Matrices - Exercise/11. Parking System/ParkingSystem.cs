using System;
using System.Linq;

namespace _11.Parking_System
{
    class ParkingSystem
    {
        static void Main()
        {
            var parkingSize = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] parking = new int[parkingSize[0], parkingSize[1]];

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var lineArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var entryRow = lineArgs[0];
                var parkingRow = lineArgs[1];
                var parkingCol = lineArgs[2];
                var parkingColumn = 0;

                if (parking[parkingRow, parkingCol] == 0)
                {
                    parkingColumn = parkingCol;
                }
                else
                {
                    for (int i = 1; i < parkingSize[1] - 1; i++)
                    {
                        if (parkingCol - i > 0 && parking[parkingRow, parkingCol - i] == 0)
                        {
                            parkingColumn = parkingCol - i;
                            break;
                        }
                        else if (parkingCol + i < parking.GetLength(1) && parking[parkingRow, parkingCol + i] == 0)
                        {
                            parkingColumn = parkingCol + i;
                            break;
                        }
                    }
                }

                if (parkingColumn == 0)
                {
                    Console.WriteLine($"Row {parkingRow} full");
                }
                else
                {
                    parking[parkingRow, parkingColumn] = -1;
                    var distance = Math.Abs(parkingRow - entryRow) + 1 + parkingColumn;
                    Console.WriteLine(distance);
                }

                input = Console.ReadLine();
            }
        }
    }
}
