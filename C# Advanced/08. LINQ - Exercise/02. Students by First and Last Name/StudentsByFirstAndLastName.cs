namespace _02.Students_by_First_and_Last_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByFirstAndLastName
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
                students.Add(new Student
                {
                    FirstName = firstName,
                    LastName = lastName
                });
                line = Console.ReadLine();
            }

            students.Where(x => string.Compare(x.FirstName, x.LastName) < 0)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
