namespace PhotoShare.Client.Core.Commands
{
    using System;

    using PhotoShare.Client.Contracts;

    public class ExitCommand : ICommand
    {
        public string Execute(params string[] data)
        {
            Console.WriteLine("Good Bye!");

            Environment.Exit(0);

            return string.Empty;
        }
    }
}
