namespace _11.Inferno_Infinity.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Factories;
    using Interfaces;

    public class CommandInterpreter
    {
        private const string CommandNamespace = "_11.Inferno_Infinity.Commands.";

        private Dictionary<string, IWeapon> weapons;

        public CommandInterpreter()
        {
            this.weapons = new Dictionary<string, IWeapon>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                List<string> inputArgs = input.Split(';').ToList();

                ExecuteCommand(inputArgs);

                input = Console.ReadLine();
            }
        }

        private void ExecuteCommand(List<string> inputArgs)
        {
            string command = inputArgs[0];
            inputArgs.RemoveAt(0);

            //Type commandType = Type.GetType(CommandNamespace + "Try" + command);
            //var da = Activator.CreateInstance(commandType, inputArgs);

            switch (command)
            {
                case "Create":
                    this.CreateWeapon(inputArgs);
                    break;
                case "Add":
                    this.AddSocket(inputArgs);
                    break;
                case "Remove":
                    this.RemoveGem(inputArgs);
                    break;
                case "Print":
                    PrintWeapon(inputArgs);
                    break;
            }

        }

        private void PrintWeapon(List<string> inputArgs)
        {
            string weaponStats = this.weapons[inputArgs[0]].ToString();
            Console.WriteLine(weaponStats);
        }

        private void RemoveGem(List<string> inputArgs)
        {
            try
            {
                string weaponName = inputArgs[0];
                int socketIndex = int.Parse(inputArgs[1]);

                this.weapons[weaponName].TryRemoveGem(socketIndex);
            }
            catch (Exception e)
            {
            }
        }

        private void AddSocket(List<string> inputArgs)
        {
            try
            {
                string weaponName = inputArgs[0];
                int socketIndex = int.Parse(inputArgs[1]);
                string[] gemParams = inputArgs[2].Split(' ');

                IGem gem = GemFactory.CreateInstance(gemParams[0], gemParams[1]);

                weapons[weaponName].TryAddGem(socketIndex, gem);
            }
            catch (Exception e)
            {
            }
        }

        private void CreateWeapon(List<string> inputArgs)
        {
            string weaponName = inputArgs[1];
            string[] weaponParams = inputArgs[0].Split(' ');
            string rarity = weaponParams[0];
            string weaponType = weaponParams[1];

            IWeapon weapon = WeaponFactory.CreateInstance(weaponType, weaponName, rarity);
            this.weapons.Add(weaponName, weapon);
        }
    }
}