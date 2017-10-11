namespace _01.ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        private int iterator;

        public ListyIterator()
        {
            this.data = new List<T>();
            this.iterator = 0;
        }

        public void Create(List<T> collection)
        {
            this.data = collection;
        }

        public bool Move()
        {
            if (this.iterator + 1 >= this.data.Count)
            {
                return false;
            }

            this.iterator++;
            return true;
        }

        public bool HasNext() => this.iterator + 1 < this.data.Count;

        public T Print()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            return this.data[iterator];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
