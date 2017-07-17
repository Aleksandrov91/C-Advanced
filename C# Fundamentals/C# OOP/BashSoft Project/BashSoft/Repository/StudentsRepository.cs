namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using BashSoft.Models;
    using Exceptions;

    public class StudentsRepository
    {
        private bool isDataInitialized = false;
        private Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;
        private RepositoryFilter filter;
        private RepositorySorter sorter;
        private Dictionary<string, Course> courses;
        private Dictionary<string, Student> students;

        public StudentsRepository(RepositorySorter sorter, RepositoryFilter filter)
        {
            this.filter = filter;
            this.sorter = sorter;
            this.studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
        }

        public void LoadData(string fileName)
        {
            if (this.isDataInitialized)
            {
                throw new DataAlreadyInitialisedException();
            }

            OutputWriter.WriteMessageOnNewLine("Reading Data...");
            this.students = new Dictionary<string, Student>();
            this.courses = new Dictionary<string, Course>();
            this.ReadsData(fileName);
        }

        public void UnloadData()
        {
            if (!this.isDataInitialized)
            {
                throw new DataNotInitializedException();
            }

            this.students = null;
            this.courses = null;
            this.isDataInitialized = false;
        }

        public void GetStudentScoreFromCourse(string courseName, string username)
        {
            if (this.IsQueryForStudentPossiblе(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, double>(username, this.courses[courseName].StudentsByName[username].MarkByCourseName[courseName]));
            }
        }

        public void GetAllStudentsFromCourse(string courseName)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");
                foreach (var studentMarksEntry in this.courses[courseName].StudentsByName)
                {
                    this.GetStudentScoreFromCourse(courseName, studentMarksEntry.Key);
                }
            }
        }

        public void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }

                Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                    .ToDictionary(x => x.Key, x => x.Value.MarkByCourseName[courseName]);

                this.filter.FilterAndTake(marks, givenFilter, studentsToTake.Value);
            }
        }

        public void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (this.IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }

                Dictionary<string, double> marks = this.courses[courseName].StudentsByName
                    .ToDictionary(x => x.Key, x => x.Value.MarkByCourseName[courseName]);

                this.sorter.OrderAndTake(marks, comparison, studentsToTake.Value);
            }
        }

        private void ReadsData(string fileName)
        {
            string path = SessionData.CurrentPath + "\\" + fileName;
            if (File.Exists(path))
            {
                Regex rgx = new Regex(@"([A-Z][a-zA-Z#\++]*_[A-Z][a-z]{2}_\d{4})\s+([A-Za-z]+\d{2}_\d{2,4})\s([\s0-9]+)");
                string[] allInputLines = File.ReadAllLines(path);
                for (int line = 0; line < allInputLines.Length; line++)
                {
                    string courseName = rgx.Match(allInputLines[line]).Groups[1].Value;
                    string userName = rgx.Match(allInputLines[line]).Groups[2].Value;
                    string scoreStr = rgx.Match(allInputLines[line]).Groups[3].Value;

                    try
                    {
                        int[] scores = scoreStr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

                        if (scores.Any(x => x > 100 || x < 0))
                        {
                            OutputWriter.DisplayException(ExceptionMessages.InvalidScore);
                            continue;
                        }

                        if (scores.Length > Course.NumberOfTasksOnExam)
                        {
                            OutputWriter.DisplayException(ExceptionMessages.InvalidNumberOfScores);
                            continue;
                        }

                        if (!this.students.ContainsKey(userName))
                        {
                            this.students.Add(userName, new Student(userName));
                        }

                        if (!this.courses.ContainsKey(courseName))
                        {
                            this.courses.Add(courseName, new Course(courseName));
                        }

                        Course course = this.courses[courseName];
                        Student student = this.students[userName];

                        student.EnrollInCourse(course);
                        student.SetMarkOnCourse(courseName, scores);
                        course.EnrollStudent(student);
                    }
                    catch (FormatException exception)
                    {
                        throw new FormatException(exception.Message + $"at line : {line}");
                    }
                }
            }
            else
            {
                throw new InvalidPathException();
            }

            this.isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private bool IsQueryForCoursePossible(string courseName)
        {
            if (this.isDataInitialized)
            {
                if (this.courses.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                throw new DataNotInitializedException();
            }
        }

        private bool IsQueryForStudentPossiblе(string courseName, string studentUserName)
        {
            if (this.IsQueryForCoursePossible(courseName) && this.courses[courseName].StudentsByName.ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InexistingStudentInDataBase);
            }
        }
    }
}
