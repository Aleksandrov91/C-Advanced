namespace TeamBuilder.App.Core
{
    using System;
    using System.Linq;
    using System.Reflection;

    using TeamBuilder.App.Contracts;
    using TeamBuilder.App.Core.Utilities;

    internal class CommandDispatcher : IDispatcher
    {
        private readonly IServiceProvider serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Dispatch(string commandName, string[] data)
        {
            Type commandType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ICommand)))
                .SingleOrDefault(n => n.Name.ToLower() == $"{commandName}Command".ToLower());

            if (commandType == null)
            {
                throw new NotSupportedException(string.Format(ErrorMessages.InvalidCommand, commandName));
            }

            var ctor = commandType.GetConstructors().First();

            Type[] ctorParams = ctor
                .GetParameters()
                .Select(pi => pi.ParameterType)
                .ToArray();

            var services = ctorParams.Select(this.serviceProvider.GetService)
                .ToArray();

            ICommand command = (ICommand)ctor.Invoke(services);

            return command.Execute(data);
        }
    }
}
