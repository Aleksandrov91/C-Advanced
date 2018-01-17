namespace TeamBuilder.App.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TeamBuilder.App.Contracts;

    internal class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IDispatcher dispatcher;

        public Engine(IReader reader, IWriter writer, IDispatcher dispatcher)
        {
            this.reader = reader;
            this.writer = writer;
            this.dispatcher = dispatcher;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    this.writer.Write("Please enter a command: ");
                    string[] commandArgs = this.reader.Read()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string commandName = commandArgs[0];
                    string[] commandParams = commandArgs.Skip(1).ToArray();

                    string result = this.dispatcher.Dispatch(commandName, commandParams);

                    this.writer.WriteLine(result);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
