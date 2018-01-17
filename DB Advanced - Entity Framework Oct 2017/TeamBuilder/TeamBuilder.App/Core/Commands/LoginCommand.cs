namespace TeamBuilder.App.Core.Commands
{
    using System;
    using TeamBuilder.App.Contracts;
    using TeamBuilder.App.Core.Utilities;
    using TeamBuilder.DTO;
    using TeamBuilder.Services.Contracts;

    internal class LoginCommand : ICommand
    {
        private readonly IUserSessionService userSession;

        public LoginCommand(IUserSessionService userSession)
        {
            this.userSession = userSession;
        }

        public string Execute(string[] data)
        {
            Check.CheckLength(2, data);

            string username = data[0];
            string password = data[1];

            if (userSession.IsLoggedIn())
            {
                throw new InvalidOperationException(ErrorMessages.LogoutFirst);
            }

            UserDto userDto = this.userSession.Login(username, password);

            if (userDto == null)
            {
                throw new ArgumentException(ErrorMessages.UserOrPasswordIsInvalid);
            }

            return $"User {username} successfully logged in!";
        }
    }
}
