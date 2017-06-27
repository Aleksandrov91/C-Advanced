using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Student_Groups
{
    public class StudentGroups
    {
        public static void Main()
        {
            var towns = new List<Town>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                if (input.Contains("="))
                {
                    var line = input.Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                    var townName = line[0];
                    var seats = line[1].Split();
                    var seatsCount = int.Parse(seats[0]);
                    var currentTown = new Town()
                    {
                        Name = townName,
                        SeatsCount = seatsCount,
                        Students = new List<Student>()
                    };
                    towns.Add(currentTown);
                }
                else
                {
                    var line = input.Split('|');
                    var studentName = line[0].Trim();
                    var studentEmail = line[1].Trim();
                    var dateRegistration = line[2].Trim();
                    var date = DateTime.ParseExact(dateRegistration, "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    var currentStudent = new Student
                    {
                        Name = studentName,
                        Email = studentEmail,
                        DateRegistration = date
                    };
                    towns[towns.Count - 1].Students.Add(currentStudent);
                }

                input = Console.ReadLine();
            }

            towns.OrderBy(x => x.Name);
            var groups = new List<Groups>();
            foreach (var town in towns)
            {
                var students = town.Students;

                students = town.Students.OrderBy(x => x.DateRegistration)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();
                while (students.Any())
                {
                    var group = new Groups();
                    group.Town = town;
                    var seats = group.Town.SeatsCount;
                    group.Students = students.Take(seats).ToList();
                    students = students.Skip(seats).ToList();
                    groups.Add(group);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (var town in groups.OrderBy(x => x.Town.Name))
            {
                Console.Write($"{town.Town.Name} => ");
                var students = town.Students;
                var last = students.Last();
                foreach (var student in students)
                {
                    if (student == last)
                    {
                        Console.WriteLine($"{student.Email}");
                    }
                    else
                    {
                        Console.Write($"{student.Email}, ");
                    }
                }
            }
        }
    }
}
