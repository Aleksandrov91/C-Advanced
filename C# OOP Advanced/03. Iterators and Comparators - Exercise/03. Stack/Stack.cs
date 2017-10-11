namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public Stack()
        {
            this.elements = new List<T>();
        }

        public void Push(T element)
        {
            this.elements.Add(element);
        }

        public void Pop()
        {
            if (this.elements.Count == 0)
            {
                throw new NullReferenceException("No elements");
            }

            this.elements.RemoveAt(this.elements.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count * 2 - 1; i >= 0; i--)
            {
                yield return this.elements[i % this.elements.Count];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
