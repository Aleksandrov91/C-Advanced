namespace BashSoft.IO.Commands
{
    using System;
    using System.Collections.Generic;
    using Attributes;
    using Contracts;
    using Execptions;

    [Alias("display")]
    public class DispalyCommand : Command
    {
        [Inject]
        private IDatabase repository;

        public DispalyCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 3)
            {
                throw new InvalidCommandException(this.Input);
            }

            string entityToDispaly = this.Data[1];
            string sortType = this.Data[2];

            if (entityToDispaly.Equals("students", StringComparison.OrdinalIgnoreCase))
            {
                IComparer<IStudent> studentComparator = this.CreateStudentComparator(sortType);
                ISimpleOrderedBag<IStudent> list = this.repository.GetAllStudentsSorted(studentComparator);
                OutputWriter.WriteMessageOnNewLine(list.JoinWith(Environment.NewLine).Trim());
            }
            else if (entityToDispaly.Equals("courses", StringComparison.OrdinalIgnoreCase))
            {
                IComparer<ICourse> courseComparer = this.CreateCourseComparer(sortType);
                ISimpleOrderedBag<ICourse> list = this.repository.GetAllCoursesSorted(courseComparer);
                OutputWriter.WriteMessageOnNewLine(list.JoinWith(Environment.NewLine).Trim());
            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }

        private IComparer<ICourse> CreateCourseComparer(string sortType)
        {
            if (sortType.Equals("ascending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<ICourse>.Create((firstCourse, secondCourse) => firstCourse.CompareTo(secondCourse));
            }

            if (sortType.Equals("descending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<ICourse>.Create((firstCourse, secondCourse) => secondCourse.CompareTo(firstCourse));
            }

            throw new InvalidCommandException(this.Input);
        }

        private IComparer<IStudent> CreateStudentComparator(string sortType)
        {
            if (sortType.Equals("ascending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<IStudent>.Create((studentOne, studentTwo) => studentOne.CompareTo(studentTwo));
            }

            if (sortType.Equals("descending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<IStudent>.Create((studentOne, studentTwo) => studentTwo.CompareTo(studentOne));
            }

            throw new InvalidCommandException(this.Input);
        }
    }
}