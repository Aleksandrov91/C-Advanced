namespace _09.Students_Enrolled_in_2014_or_2015
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsEnrolled
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var students = new List<int[]>();

            while (inputLine != "END")
            {
                var studentsData = inputLine.Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                students.Add(studentsData);

                inputLine = Console.ReadLine();
            }

            students
                .Where(s => s[0] % 100 == 14 || s[0] % 100 == 15)
                .Select(arr => arr.Skip(1))
                .ToList()
                .ForEach(s => Console.WriteLine(string.Join(" ", s)));
        }
    }
}
