using System;

namespace _01.Students_Results
{
    public class StudentsResults
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format(
                "{0, -10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                "Name", "CAdv", "COOP", "AdvOOP", "Average"));
            for (int i = 0; i < n; i++)
            {
                var studentArgs = Console.ReadLine().Split(new[] {'-', ','}, StringSplitOptions.RemoveEmptyEntries);

                var studentName = studentArgs[0].Trim();
                var cAdvGrade = double.Parse(studentArgs[1]);
                var cOOPGrade = double.Parse(studentArgs[2]);
                var advancedOOPGrade = double.Parse(studentArgs[3]);
                var averageGrade = (cAdvGrade + cOOPGrade + advancedOOPGrade) / 3;

                Console.WriteLine(string.Format(
                    "{0, -10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                    studentName, cAdvGrade, cOOPGrade, advancedOOPGrade, averageGrade));
            }
        }
    }
}
