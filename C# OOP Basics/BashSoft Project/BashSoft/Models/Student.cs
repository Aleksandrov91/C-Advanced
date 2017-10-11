namespace BashSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exceptions;

    public class Student
    {
        private string userName;
        private Dictionary<string, Course> enrolledCourses;
        private Dictionary<string, double> markByCourseName;

        public Student(string userName)
        {
            this.UserName = userName;
            this.enrolledCourses = new Dictionary<string, Course>();
            this.markByCourseName = new Dictionary<string, double>();
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this.userName = value;
            }
        }

        public IReadOnlyDictionary<string, Course> EnrolledCourses
        {
            get { return this.enrolledCourses; }
        }

        public IReadOnlyDictionary<string, double> MarkByCourseName
        {
            get { return this.markByCourseName; }
        }

        public void EnrollInCourse(Course course)
        {
            if (this.enrolledCourses.ContainsKey(course.Name))
            {
                throw new DuplicateEntryInStructureException(this.UserName, course.Name);
            }

            this.enrolledCourses.Add(course.Name, course);
        }

        public void SetMarkOnCourse(string courseName, params int[] scores)
        {
            if (!this.enrolledCourses.ContainsKey(courseName))
            {
                throw new CourseNotFoundException();
            }

            if (scores.Length > Course.NumberOfTasksOnExam)
            {
                
                throw new ArgumentOutOfRangeException(ExceptionMessages.InvalidNumberOfScores);
            }

            this.markByCourseName.Add(courseName, this.CalculateMark(scores));
        }

        private double CalculateMark(int[] scores)
        {
            double pecentageOfSolvedExam = scores.Sum() / (double)(Course.NumberOfTasksOnExam * Course.MaxScoreOnExamTask);
            double mark = (pecentageOfSolvedExam * 4) + 2;
            return mark;
        }
    }
}
