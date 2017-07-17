namespace BashSoft.Exceptions
{
    using System;

    public class CourseNotFoundException : Exception
    {
        private const string SetMarkOnCourse =
            "The number of scores for the given course is greater than the possible.";

        public CourseNotFoundException()
            : base(SetMarkOnCourse)
        {
        }

        public CourseNotFoundException(string message)
            : base(message)
        {
        }
    }
}