namespace TeamBuilder.App
{
    using System;

    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using TeamBuilder.App.Contracts;
    using TeamBuilder.App.Core;
    using TeamBuilder.App.Readers;
    using TeamBuilder.App.Writers;
    using TeamBuilder.Data;
    using TeamBuilder.Services.Contracts;
    using TeamBuilder.Services;

    public class Application
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IServiceProvider serviceProvider = GetProvider();
            IDispatcher dispatcher = new CommandDispatcher(serviceProvider);

            IEngine engine = new Engine(reader, writer, dispatcher);

            engine.Run();
        }

        private static IServiceProvider GetProvider()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<TeamBuilderContext>(cfg => cfg.UseSqlServer(Configuration.ConnectionString));
            serviceCollection.AddAutoMapper();

            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IUserSessionService, UserSessionService>();
            serviceCollection.AddTransient<IWriter, ConsoleWriter>();

            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
