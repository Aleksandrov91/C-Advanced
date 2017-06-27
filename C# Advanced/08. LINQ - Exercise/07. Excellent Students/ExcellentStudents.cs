namespace _07.Excellent_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExcellentStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<Student>();

            while (input != "END")
            {
                var args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = args[0];
                var lastName = args[1];
                var grades = new string[args.Length - 2];
                Array.Copy(args, 2, grades, 0, args.Length - 2);

                students.Add(new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grades = grades.Select(int.Parse).ToArray()
                });

                input = Console.ReadLine();
            }

            students
                .Where(s => s.Grades.Contains(6))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
