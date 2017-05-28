using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.ParkingLot
{
    public class ParkingLot
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (input != "END")
            {
                var args = Regex.Split(input, ", ");

                var status = args[0];
                var carNumber = args[1];

                if (status == "IN")
                {
                    parking.Add(carNumber);
                }
                else
                {
                    if (parking.Contains(carNumber))
                    {
                        parking.Remove(carNumber);
                    }
                }

                input = Console.ReadLine();
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }
        }
    }
}
