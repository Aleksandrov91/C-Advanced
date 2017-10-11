namespace _09.Linked_List_Traversal
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var linkedList = new LinkedList<int>();
            var inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var data = Console.ReadLine().Split();

                if (data[0] == "Add")
                {
                    linkedList.Add(int.Parse(data[1]));
                }
                else
                {
                    linkedList.Remove(int.Parse(data[1]));
                }
            }

            Console.WriteLine(linkedList.Count);
            Console.WriteLine(string.Join(" ", linkedList));
        }
    }
}
