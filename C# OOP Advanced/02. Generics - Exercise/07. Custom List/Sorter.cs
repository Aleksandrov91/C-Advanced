namespace _07.Custom_List
{
    using System.Collections.Generic;

    public class Sorter<T>
    {
        public static List<T> Sort(List<T> collection)
        {
            collection.Sort();
            return collection;
        }
    }
}
