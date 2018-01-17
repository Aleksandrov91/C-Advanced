namespace Employees.Client.Readers
{
    using System;

    using Employees.Client.Contracts;

    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
