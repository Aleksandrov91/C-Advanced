using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    public class MentorGroup
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine();
            var studentReport = new SortedDictionary<string, Student>();
            while (firstInput != "end of dates")
            {
                var firstLine = firstInput.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var userName = firstLine[0].ToString();
                var student = new Student
                {
                    Dates = new List<DateTime>(),
                    Comments = new List<string>()
                };

                if (!studentReport.ContainsKey(userName))
                {
                    studentReport[userName] = student;
                }

                for (int i = 1; i < firstLine.Length; i++)
                {
                    var date = firstLine[i].ToString();
                    var currentDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    studentReport[userName].Dates.Add(currentDate);
                }

                firstInput = Console.ReadLine();
            }

            var secondInput = Console.ReadLine();
            while (secondInput != "end of comments")
            {
                var secondLine = secondInput.Split('-');
                var name = secondLine[0];
                var comment = secondLine[1];
                if (!studentReport.ContainsKey(name))
                {
                    secondInput = Console.ReadLine();
                    continue;
                }
                studentReport[name].Comments.Add(comment);
                secondInput = Console.ReadLine();
            }

            foreach (var student in studentReport)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");
                var studentComments = student.Value.Comments;
                foreach (var comment in studentComments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                var dates = student.Value.Dates;
                foreach (var date in dates.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
