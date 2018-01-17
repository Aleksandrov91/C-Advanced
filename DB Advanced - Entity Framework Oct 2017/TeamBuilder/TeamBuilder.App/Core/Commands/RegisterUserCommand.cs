namespace TeamBuilder.App.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TeamBuilder.App.Contracts;
    using TeamBuilder.App.Core.Utilities;
    using TeamBuilder.DTO;
    using TeamBuilder.Models;
    using TeamBuilder.Models.Enums;
    using TeamBuilder.Services.Contracts;

    internal class RegisterUserCommand : ICommand
    {
        private readonly IUserService userService;
        private readonly IUserSessionService userSession;

        public RegisterUserCommand(IUserService userService, IUserSessionService userSession)
        {
            this.userService = userService;
            this.userSession = userSession;
        }

        public string Execute(string[] data)
        {
            Check.CheckLength(7, data);

            string username = data[0];
            string password = data[1];
            string repeatPassword = data[2];
            string firstName = data[3];
            string lastName = data[4];
            int age = int.Parse(data[5]);
            bool isGenderValid = Enum.TryParse(data[6], true, out Gender gender);

            User user = new User
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Gender = gender
            };

            if (password != repeatPassword)
            {
                throw new InvalidOperationException(ErrorMessages.PasswordDoesNotMatch);
            }
            else if (this.userService.IsUserExisting(username))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.UsernameIsTaken, username));
            }
            else if (!isGenderValid)
            {
                throw new ArgumentException(ErrorMessages.GenderNotValid);
            }
            else if (this.userSession.IsLoggedIn())
            {
                throw new InvalidOperationException(ErrorMessages.LogoutFirst);
            }

            UserDto userDto =  this.userService.Register(username, password, firstName, lastName, age, gender);

            return $"User {username} was registered successfully!";
        }
    }
}
