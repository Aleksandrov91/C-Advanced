using System;
using System.Collections.Generic;
using System.IO;

namespace BashSoft
{
    public static class StudentsRepository
    {
        public static bool IsDataInitialized = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        public static void InitializeData(string fileName)
        {
            if (!IsDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading Data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadsData(fileName);
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }

        private static void ReadsData(string fileName)
        {
            //string input = Console.ReadLine();

            //while (!string.IsNullOrEmpty(input))
            //{
            //    string[] tokens = input.Split(' ');
            //    string course = tokens[0];
            //    string student = tokens[1];
            //    int mark = int.Parse(tokens[2]);

            //    if (!studentsByCourse.ContainsKey(course))
            //    {
            //        studentsByCourse[course] = new Dictionary<string, List<int>>();
            //    }

            //    if (!studentsByCourse[course].ContainsKey(student))
            //    {
            //        studentsByCourse[course][student] = new List<int>();
            //    }

            //    studentsByCourse[course][student].Add(mark);

            //    input = Console.ReadLine();
            //}

            string path = SessionData.currentPath + "\\" + fileName;
            if (File.Exists(path))
            {
                string[] allInputLines = File.ReadAllLines(path);

                for (int line = 0; line < allInputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[line]))
                    {
                        string[] data = allInputLines[line].Split(' ');
                        string course = data[0];
                        string student = data[1];
                        int mark = int.Parse(data[2]);

                        if (!studentsByCourse.ContainsKey(course))
                        {
                            studentsByCourse[course] = new Dictionary<string, List<int>>();
                        }

                        if (!studentsByCourse[course].ContainsKey(student))
                        {
                            studentsByCourse[course][student] = new List<int>();
                        }

                        studentsByCourse[course][student].Add(mark);
                    }
                }
            }

            IsDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (IsDataInitialized)
            {
                if (studentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        private static bool IsQueryForStudentPossiblе(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        public static void GetStudentScoreFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentPossiblе(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
            }
        }

        public static void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");
                foreach (var studentMarksEntry in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studentMarksEntry);
                }
            }
        }
    }
}
