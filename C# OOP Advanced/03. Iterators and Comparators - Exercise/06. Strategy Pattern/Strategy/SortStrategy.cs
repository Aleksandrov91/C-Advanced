namespace _06.Strategy_Pattern
{
    using System.Collections.Generic;

    public abstract class SortStrategy
    {
        public abstract void Sort(List<Person> list);
    }
}
