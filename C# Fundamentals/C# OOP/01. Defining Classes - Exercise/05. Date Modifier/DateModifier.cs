namespace _05.Date_Modifier
{
    using System;

    public class DateModifier
    {
        public static double CalculateDifference(string firstDateString, string secondDateString)
        {
            var firstDate = Convert.ToDateTime(firstDateString);
            var secondDate = Convert.ToDateTime(secondDateString);

            return Math.Abs((secondDate - firstDate).TotalDays);
        }
    }
}
