namespace _13.Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var family = new List<Person>();
            var familyMembers = new Queue<string>();

            var memberToPrint = Console.ReadLine();

            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                if (inputLine.Contains("-"))
                {
                    familyMembers.Enqueue(inputLine);
                }
                else
                {
                    var inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    family.Add(new Person(inputData[0], inputData[1], inputData[2]));
                }

                inputLine = Console.ReadLine();
            }

            while (familyMembers.Count != 0)
            {
                var data = familyMembers.Dequeue().Split(new[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Person parent;
                Person children;

                if (data[0].Contains('/'))
                {
                    var parentBirthday = data[0];
                    parent = family.FirstOrDefault(p => p.Birthday == parentBirthday);

                    if (data[1].Contains('/'))
                    {
                        var childrenBirthday = data[1];
                        children = family.FirstOrDefault(ch => ch.Birthday == childrenBirthday);
                    }
                    else
                    {
                        var childrenFirstName = data[1];
                        var childrenLastName = data[2];
                        children = family.FirstOrDefault(ch => ch.FirstName == childrenFirstName && ch.LastName == childrenLastName);
                    }
                }
                else
                {
                    var parentFirstName = data[0];
                    var parentLastName = data[1];
                    parent =
                        family.FirstOrDefault(p => p.FirstName == parentFirstName && p.LastName == parentLastName);

                    if (data[2].Contains('/'))
                    {
                        var childrenBirthday = data[2];
                        children = family.FirstOrDefault(ch => ch.Birthday == childrenBirthday);
                    }
                    else
                    {
                        var childrenFirstName = data[2];
                        var childrenLastName = data[3];
                        children =
                            family.FirstOrDefault(ch => ch.FirstName == childrenFirstName &&
                                                         ch.LastName == childrenLastName);
                    }
                }

                parent.AddChildren(children);
                children.AddParent(parent);
            }

            Person printPerson;

            if (memberToPrint.Contains('/'))
            {
                printPerson = family.FirstOrDefault(p => p.Birthday == memberToPrint);
            }
            else
            {
                var personToPrintData = memberToPrint.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                printPerson = family.FirstOrDefault(p => p.FirstName == personToPrintData[0] &&
                                                        p.LastName == personToPrintData[1]);
            }

            Console.WriteLine(printPerson.ToString());
        }
    }
}
