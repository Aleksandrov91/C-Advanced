namespace _06.Strategy_Pattern
{
    using System.Collections;
    using System.Collections.Generic;

    public class SortedList : IEnumerable<Person>
    {
        private List<Person> persons;
        private SortStrategy strategy;

        public SortedList()
        {
            this.persons = new List<Person>();
        }
        
        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.strategy = sortStrategy;
        }

        public void Add(Person person)
        {
            this.persons.Add(person);
        }

        public void Sort()
        {
            this.strategy.Sort(this.persons);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return this.persons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
