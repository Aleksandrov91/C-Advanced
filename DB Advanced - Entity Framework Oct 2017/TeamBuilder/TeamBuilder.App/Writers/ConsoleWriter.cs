namespace TeamBuilder.App.Writers
{
    using System;

    using TeamBuilder.App.Contracts;

    internal class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
