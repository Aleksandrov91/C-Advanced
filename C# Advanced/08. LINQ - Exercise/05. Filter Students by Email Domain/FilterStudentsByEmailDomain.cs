namespace _05.Filter_Students_by_Email_Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterStudentsByEmailDomain
    {
        public static void Main()
        {
            var filter = "@gmail.com";
            var line = Console.ReadLine();
            var students = new List<Student>();

            while (line != "END")
            {
                var lineArgs = line.Split(' ');
                var fisrtName = lineArgs[0];
                var lastName = lineArgs[1];
                var email = lineArgs[2];

                students.Add(new Student
                {
                    FistName = fisrtName,
                    LastName = lastName,
                    Email = email
                });

                line = Console.ReadLine();
            }

            students.Where(x => x.Email.Contains(filter))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FistName} {s.LastName}"));
        }
    }
}
