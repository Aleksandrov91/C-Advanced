namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Client.Contracts;
    using PhotoShare.Client.Sessions;
    using PhotoShare.Models;
    using PhotoShare.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LogoutCommand : ICommand
    {
        public string Execute(params string[] data)
        {
            if (CurrentSession.LoggedUser == null)
            {
                throw new ArgumentException("You should log in first in order to logout.");
            }

            string loggedUsername = CurrentSession.LoggedUser.Username;

            CurrentSession.LoggedUser = null;

            return $"User {loggedUsername} successfully logged out!";
        }
    }
}
