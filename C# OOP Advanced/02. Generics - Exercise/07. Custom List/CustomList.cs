namespace _07.Custom_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private IList<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }

        public IList<T> Data
        {
            get { return this.data; }
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove(int index)
        {
            var element = this.data[index];
            this.data.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var temp = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return this.data.Where(v => v.CompareTo(element) > 0).Count();
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public void Sort()
        {
            this.data = Sorter<T>.Sort(this.data.ToList());
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
