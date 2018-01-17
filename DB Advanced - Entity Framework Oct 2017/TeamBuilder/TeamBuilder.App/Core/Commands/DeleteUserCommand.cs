namespace TeamBuilder.App.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamBuilder.App.Contracts;
    using TeamBuilder.App.Core.Utilities;
    using TeamBuilder.Models;
    using TeamBuilder.Services.Contracts;

    internal class DeleteUserCommand : ICommand
    {
        private IUserSessionService userSession;
        private IUserService userService;

        public DeleteUserCommand(IUserSessionService userSession, IUserService userService)
        {
            this.userService = userService;
            this.userSession = userSession;
        }

        public string Execute(string[] data)
        {
            if (!this.userSession.IsLoggedIn())
            {
                throw new InvalidOperationException(ErrorMessages.LoginFirst);
            }

            User currentUser = this.userSession.User;

            this.userSession.Logout();
            this.userService.Delete(currentUser.Id);

            return $"User {currentUser.Username} was deleted successfully!";
        }
    }
}
