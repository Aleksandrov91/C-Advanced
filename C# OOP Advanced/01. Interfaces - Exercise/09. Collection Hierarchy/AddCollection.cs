namespace _09.Collection_Hierarchy
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    public class AddCollection<T> : IAddCollection<T>
    {
        public AddCollection()
        {
            this.Data = new List<T>();
        }

        protected IList<T> Data { get; }
        
        public virtual int Add(T element)
        {
            this.Data.Add(element);
            return this.Data.Count - 1;
        }
    }
}
