namespace _11.Students_Joined_to_Specialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsJoinedToSpecialties
    {
        public static void Main()
        {
            var specialities = new List<StudentSpecialty>();
            var students = new List<Student>();

            var inputLine = Console.ReadLine();

            while (inputLine != "Students:")
            {
                var inputData = inputLine.Split(' ');

                specialities.Add(new StudentSpecialty
                {
                    SpecialityName = inputData[0] + " " + inputData[1],
                    FacultyNumer = int.Parse(inputData[2])
                });

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                var inputData = inputLine.Split(' ');

                students.Add(new Student
                {
                    StudentName = inputData[1] + " " + inputData[2],
                    FacultyNumber = int.Parse(inputData[0])
                });
                inputLine = Console.ReadLine();
            }

            students.Join(specialities, s => s.FacultyNumber, sp => sp.FacultyNumer,
                    (s, sp) => new
                    {
                        Name = s.StudentName,
                        FacultyNumber = s.FacultyNumber,
                        Speciality = sp.SpecialityName
                    })
                .OrderBy(x => x.Name)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} {s.FacultyNumber} {s.Speciality}"));
        }
    }
}
