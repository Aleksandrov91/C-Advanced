namespace _02.Sum_Numbers
{
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionMethods
    {
        public static string PrintSumAndCount(this List<int> list)
        {
            return $"{list.Count}\r\n{list.Sum()}";
        }
    }
}
