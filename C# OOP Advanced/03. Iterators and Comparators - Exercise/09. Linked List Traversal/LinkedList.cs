namespace _09.Linked_List_Traversal
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }

            public Node Next { get; set; }
        }

        public Node Head { get; private set; }

        public Node Tail { get; private set; }

        public int Count { get; private set; }

        public void Add(T item)
        {
            var old = this.Tail;

            this.Tail = new Node(item);

            if (IsEmpty())
            {
                this.Head = this.Tail;
            }
            else
            {
                old.Next = this.Tail;
            }

            this.Count++;
        }

        public T Remove(T element)
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            var current = this.Head;

            if (current.Value.CompareTo(element) == 0)
            {
                T item = current.Value;

                this.Head = current.Next;
                this.Count--;

                if (this.IsEmpty())
                {
                    this.Tail = null;
                }

                return item;
            }

            while (current.Next != null)
            {
                if (current.Next.Value.CompareTo(element) == 0)
                {
                    T item = current.Next.Value;

                    current.Next = current.Next.Next;
                    this.Count--;

                    if (this.IsEmpty())
                    {
                        this.Tail = null;
                    }

                    return item;
                }

                current = current.Next;
            }

            return default(T);
        }

        private bool IsEmpty()
        {
            return this.Count == 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}