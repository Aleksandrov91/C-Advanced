namespace _09.Collection_Hierarchy
{
    using Interfaces;

    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        public int Count
        {
            get { return this.Data.Count; }
        }

        public override T Remove()
        {
            var element = this.Data[0];
            this.Data.RemoveAt(0);
            return element;
        }
    }
}
