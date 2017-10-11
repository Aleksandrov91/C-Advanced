namespace _01.Students_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByGroup
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var students = new List<Student>();

            while (line != "END")
            {
                var lineArgs = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = lineArgs[0];
                var lastName = lineArgs[1];
                var group = int.Parse(lineArgs[2]);

                students.Add(
                    new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Group = group
                    });

                line = Console.ReadLine();
            }

            students
               .Where(s => s.Group == 2)
               .OrderBy(x => x.FirstName)
               .ToList()
               .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
