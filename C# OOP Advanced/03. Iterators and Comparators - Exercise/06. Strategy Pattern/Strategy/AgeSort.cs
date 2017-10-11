namespace _06.Strategy_Pattern.Strategy
{
    using System.Collections.Generic;

    public class AgeSort : SortStrategy
    {
        public override void Sort(List<Person> list)
        {
            list.Sort(new AgeComparer());
        }
    }
}
