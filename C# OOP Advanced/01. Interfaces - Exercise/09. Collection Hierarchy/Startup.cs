namespace _09.Collection_Hierarchy
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var firstCollection = new StringBuilder();
            var secondCollection = new StringBuilder();
            var thirdCollection = new StringBuilder();

            var addCollection = new AddCollection<string>();
            var addRemoveCollection = new AddRemoveCollection<string>();
            var myList = new MyList<string>();

            var inputLine = Console.ReadLine().Split(' ');

            foreach (var element in inputLine)
            {
                firstCollection.Append(addCollection.Add(element)).Append(" ");
                secondCollection.Append(addRemoveCollection.Add(element)).Append(" ");
                thirdCollection.Append(myList.Add(element)).Append(" ");
            }

            Console.WriteLine(firstCollection);
            Console.WriteLine(secondCollection);
            Console.WriteLine(thirdCollection);

            secondCollection.Clear();
            thirdCollection.Clear();

            var numberOfElementsToRemove = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfElementsToRemove; i++)
            {
                secondCollection.Append(addRemoveCollection.Remove()).Append(" ");
                thirdCollection.Append(myList.Remove()).Append(" ");
            }

            Console.WriteLine(secondCollection);
            Console.WriteLine(thirdCollection);
        }
    }
}
