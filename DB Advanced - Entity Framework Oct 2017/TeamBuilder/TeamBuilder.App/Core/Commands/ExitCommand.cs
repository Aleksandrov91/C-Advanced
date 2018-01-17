namespace TeamBuilder.App.Core.Commands
{
    using System;
    using TeamBuilder.App.Contracts;

    internal class ExitCommand : ICommand
    {
        private readonly IWriter writer;

        public ExitCommand(IWriter writer)
        {
            this.writer = writer;
        }

        public string Execute(string[] data)
        {
            this.writer.WriteLine("Good Bye!");

            Environment.Exit(0);

            return string.Empty;
        }
    }
}
