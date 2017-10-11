namespace BashSoft
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;
    using Execptions;
    using IO.Commands;

    public class CommandInterpreter : IInterpreter
    {
        private IContentComparer judge;
        private IDatabase repository;
        private IDirectoryManager inputOutputManager;
        private BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;

        public CommandInterpreter(IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public void InterpretCommand(string input)
        {
            string[] data = input.Split();
            string commandName = data[0];

            try
            {
                IExecutable command = this.ParseCommand(input, commandName, data);
                command.Execute();
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private IExecutable ParseCommand(string input, string command, string[] data)
        {
            object[] parametersForConstruction = new object[]
            {
                input, data
            };

            Type typeOfCommand = Assembly.GetExecutingAssembly().GetTypes()
                .First(type => type.GetCustomAttributes(typeof(Alias))
                                   .Where(atr => atr.Equals(command))
                                   .ToArray().Length > 0);

            Type typeOfInterpreter = typeof(CommandInterpreter);

            Command exe = (Command)Activator.CreateInstance(typeOfCommand, parametersForConstruction);

            FieldInfo[] fieldsOfCommand = typeOfCommand.GetFields(this.flags);

            FieldInfo[] fieldsOfInterpreter =
                typeOfInterpreter.GetFields(this.flags);

            foreach (var fieldOfCommand in fieldsOfCommand)
            {
                Attribute attribute = fieldOfCommand.GetCustomAttribute(typeof(InjectAttribute));

                if (attribute == null)
                {
                    if (fieldsOfInterpreter.Any(x => x.FieldType == fieldOfCommand.FieldType))
                    {
                        fieldOfCommand.SetValue(exe, fieldsOfInterpreter
                            .First(x => x.FieldType == fieldOfCommand.FieldType)
                            .GetValue(this));
                    }
                }
            }

            return exe;
        }
    }
}
