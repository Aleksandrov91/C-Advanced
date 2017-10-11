namespace _06.Strategy_Pattern
{
    using System.Collections.Generic;
    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var result = x.Age.CompareTo(y.Age);

            return result;
        }
    }
}
