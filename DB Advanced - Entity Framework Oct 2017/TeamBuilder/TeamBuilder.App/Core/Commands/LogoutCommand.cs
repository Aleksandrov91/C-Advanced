namespace TeamBuilder.App.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamBuilder.App.Contracts;
    using TeamBuilder.App.Core.Utilities;
    using TeamBuilder.DTO;
    using TeamBuilder.Models;
    using TeamBuilder.Services.Contracts;

    internal class LogoutCommand : ICommand
    {
        private IUserSessionService userSession;

        public LogoutCommand(IUserSessionService userSession)
        {
            this.userSession = userSession;
        }

        public string Execute(string[] data)
        {
            if (!this.userSession.IsLoggedIn())
            {
                throw new InvalidOperationException(ErrorMessages.LoginFirst);
            }

            string loggedUserUsername = this.userSession.User.Username;

            return $"User {loggedUserUsername} successfully logged out!";
        }
    }
}
