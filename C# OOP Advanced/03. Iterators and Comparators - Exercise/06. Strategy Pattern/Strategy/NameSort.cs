namespace _06.Strategy_Pattern
{
    using System;
    using System.Collections.Generic;

    public class NameSort : SortStrategy
    {
        public override void Sort(List<Person> list)
        {
           list.Sort(new NameComparer());
        }
    }
}
