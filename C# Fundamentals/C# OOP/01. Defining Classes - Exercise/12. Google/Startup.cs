namespace _12.Google
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var persons = new Dictionary<string, Person>();

            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var personName = inputData[0];
                var type = inputData[1];

                if (!persons.ContainsKey(personName))
                {
                    persons[personName] = new Person(personName);
                }

                switch (type)
                {
                    case "company":
                        var company = new Company(inputData[2], inputData[3], double.Parse(inputData[4]));
                        persons[personName].Company = company;
                        break;
                    case "pokemon":
                        var pokemon = new Pokemon(inputData[2], inputData[3]);
                        persons[personName].Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        var parents = new Parents(inputData[2], inputData[3]);
                        persons[personName].Parents.Add(parents);
                        break;
                    case "children":
                        var children = new Children(inputData[2], inputData[3]);
                        persons[personName].Childrens.Add(children);
                        break;
                    case "car":
                        var car = new Car(inputData[2], int.Parse(inputData[3]));
                        persons[personName].Car = car;
                        break;
                }

                inputLine = Console.ReadLine();
            }

            var personToPrint = Console.ReadLine();

            if (persons.ContainsKey(personToPrint))
            {
                var person = persons[personToPrint];
                Console.WriteLine(person.ToString());
            }
        }
    }
}
