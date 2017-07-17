namespace _03.Oldest_Family_Member
{
    using System;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var numberOfPeople = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personData = Console.ReadLine()
                    .Split(' ');

                var person = new Person
                {
                    Name = personData[0],
                    Age = int.Parse(personData[1])
                };

                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
