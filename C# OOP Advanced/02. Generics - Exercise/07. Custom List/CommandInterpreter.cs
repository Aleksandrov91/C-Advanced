namespace _07.Custom_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        private bool isRunning;
        private CustomList<string> myList;

        public CommandInterpreter()
        {
            this.isRunning = true;
            this.myList = new CustomList<string>();
        }

        public void Run()
        {
            while (isRunning)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                ExecuteCommand(input);
            }
        }

        private void ExecuteCommand(List<string> commandArgs)
        {
            var command = commandArgs[0];
            commandArgs.RemoveAt(0);

            switch (command)
            {
                case "Add":
                    myList.Add(commandArgs[0]);
                    break;
                case "Remove":
                    myList.Remove(int.Parse(commandArgs[0]));
                    break;
                case "Contains":
                    Console.WriteLine(myList.Contains(commandArgs[0]));
                    break;
                case "Swap":
                    myList.Swap(int.Parse(commandArgs[0]), int.Parse(commandArgs[1]));
                    break;
                case "Greater":
                    Console.WriteLine(myList.CountGreaterThan(commandArgs[0]));
                    break;
                case "Max":
                    Console.WriteLine(myList.Max());
                    break;
                case "Min":
                    Console.WriteLine(myList.Min());
                    break;
                case "Print":
                    foreach (var element in this.myList)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case "Sort":
                    myList.Sort();
                    break;
                case "END":
                    this.isRunning = false;
                    break;
            }
        }
    }
}
