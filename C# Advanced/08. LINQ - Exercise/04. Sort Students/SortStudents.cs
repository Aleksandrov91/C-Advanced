namespace _04.Sort_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortStudents
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var students = new List<Student>();

            while (line != "END")
            {
                var lineArgs = line.Split(' ');
                var fisrtName = lineArgs[0];
                var lastName = lineArgs[1];
                students.Add(new Student
                {
                    FirstName = fisrtName,
                    LastName = lastName
                });

                line = Console.ReadLine();
            }

            students.OrderBy(s => s.LastName)
                .ThenByDescending(s => s.FirstName)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
