namespace _06.Filter_Students_by_Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterStudentsByPhone
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<string[]>();

            while (input != "END")
            {
                students.Add(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                input = Console.ReadLine();
            }

            students
                .Where(n => n[2].StartsWith("+3592") || n[2].StartsWith("02"))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s[0]} {s[1]}"));
        }
    }
}
