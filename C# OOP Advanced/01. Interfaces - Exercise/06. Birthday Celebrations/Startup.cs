namespace _06.Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;

    public class Startup
    {
        public static void Main()
        {
            var birthdatesLog = new List<IBirthdate>();

            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var inputArgs = inputLine.Split(' ').ToList();

                var type = inputArgs[0];
                inputArgs.Remove(type);

                switch (type)
                {
                    case "Citizen":
                        birthdatesLog.Add(new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3]));
                        break;
                    case "Pet":
                        birthdatesLog.Add(new Pet(inputArgs[0], inputArgs[1]));
                        break;
                    case "Robot":
                        break;
                }

                inputLine = Console.ReadLine();
            }

            var birthDateFilter = Console.ReadLine();

            foreach (var birthdate in birthdatesLog.Where(b => b.Birthdate.EndsWith(birthDateFilter)).ToList())
            {
                Console.WriteLine(birthdate.Birthdate);
            }
        }
    }
}
