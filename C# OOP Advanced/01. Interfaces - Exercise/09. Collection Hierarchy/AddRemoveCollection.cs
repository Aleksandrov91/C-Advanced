namespace _09.Collection_Hierarchy
{
    using System.Collections.Generic;
    using Interfaces;

    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        public override int Add(T element)
        {
            this.Data.Insert(0, element);
            return 0;
        }

        public virtual T Remove()
        {
            var element = this.Data[Data.Count - 1];
            this.Data.RemoveAt(this.Data.Count - 1);
            return element;
        }
    }
}
