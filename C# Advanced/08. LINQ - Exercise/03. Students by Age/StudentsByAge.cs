namespace _03.Students_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByAge
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var students = new List<Student>();

            while (line != "END")
            {
                var lineArgs = line.Split(' ');
                var firstName = lineArgs[0];
                var lastName = lineArgs[1];
                var age = int.Parse(lineArgs[2]);

                students.Add(new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                });

                line = Console.ReadLine();
            }

            students.Where(a => a.Age >= 18 && a.Age <= 24)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName} {s.Age}"));
        }
    }
}
