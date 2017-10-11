namespace _08.Pet_Clinic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class Startup
    {
        private static Dictionary<string, Pet> pets;
        private static Dictionary<string, Clinic> clinics;

        public static void Main()
        {
            pets = new Dictionary<string, Pet>();
            clinics = new Dictionary<string, Clinic>();

            var inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var inputData = Console.ReadLine().Split(' ').ToList();
                var command = inputData[0];
                inputData.RemoveAt(0);
                ExecuteCommand(command, inputData);
            }
        }

        public static void ExecuteCommand(string command, List<string> inputData)
        {
            switch (command)
            {
                case "Create":
                    CreateClinicOrPet(inputData);
                    break;
                case "Add":
                    AddToClinic(inputData);
                    break;
                case "Release":
                    Console.WriteLine(clinics[inputData[0]].TryReleasePet());
                    break;
                case "HasEmptyRooms":
                    Console.WriteLine(clinics[inputData[0]].HasEmptyRooms());
                    break;
                case "Print":
                    PrintClinic(inputData);
                    break;
            }
        }

        private static void CreateClinicOrPet(List<string> inputData)
        {
            if (inputData.Count > 3)
            {
                var pet = new Pet(inputData[1], int.Parse(inputData[2]), inputData[3]);
                pets.Add(inputData[1], pet);
                return;
            }

            try
            {
                var clinic = new Clinic(inputData[1], int.Parse(inputData[2]));
                clinics.Add(inputData[1], clinic);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static void AddToClinic(List<string> inputData)
        {
            var result = clinics[inputData[1]].TryAddPet(pets[inputData[0]]);

            if (result)
            {
                pets.Remove(inputData[0]);
                Console.WriteLine(true);
                return;
            }

            Console.WriteLine(false);
        }

        private static void PrintClinic(List<string> inputData)
        {
            var currentClinic = inputData[0];
            string information = string.Empty;

            if (inputData.Count > 1)
            {
                information = clinics[currentClinic].Print(int.Parse(inputData[1]) - 1);
            }
            else
            {
                information = clinics[currentClinic].Print();
            }

            Console.WriteLine(information);
        }
    }
}
