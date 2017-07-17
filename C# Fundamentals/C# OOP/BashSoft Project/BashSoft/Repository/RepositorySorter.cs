namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RepositorySorter
    {
        public void OrderAndTake(Dictionary<string, double> studentsMarks, string comparisson, int studentsToTake)
        {
            comparisson = comparisson.ToLower();
            if (comparisson == "ascending")
            {
                this.PrintStudents(studentsMarks.OrderBy(x => x.Value)
                    .Take(studentsToTake)
                    .ToDictionary(x => x.Key, x => x.Value));
            }
            else if (comparisson == "descending")
            {
                this.PrintStudents(studentsMarks.OrderByDescending(x => x.Value)
                    .Take(studentsToTake)
                    .ToDictionary(x => x.Key, x => x.Value));
            }
            else
            {
                throw new ArgumentOutOfRangeException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private void PrintStudents(Dictionary<string, double> studentsSorted)
        {
            foreach (KeyValuePair<string, double> keyValuePair in studentsSorted)
            {
                OutputWriter.PrintStudent(keyValuePair);
            }
        }
    }
}
