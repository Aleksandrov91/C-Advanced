using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var grades = new List<double>();
                for (int j = 1; j < line.Length; j++)
                {
                    grades.Add(double.Parse(line[j]));
                }

                var student = new Student()
                {
                    Name = line[0],
                    Grades = grades
                };
                if (student.AverageGrade >= 5.00)
                {
                    students.Add(student);
                }
            }

            foreach (var student in students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}
