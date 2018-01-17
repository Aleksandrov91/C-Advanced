namespace TeamBuilder.App.Readers
{
    using System;

    using TeamBuilder.App.Contracts;

    internal class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
