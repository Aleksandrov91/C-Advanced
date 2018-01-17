namespace TeamBuilder.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamBuilder.DTO;
    using TeamBuilder.Models;
    using TeamBuilder.Models.Enums;

    public interface IUserService
    {
        bool IsUserExisting(string username);

        User ByUserNameAndPassword(string username, string password);

        UserDto Register(string username, string password, string firstName, string lastName, int age, Gender gender);

        void Delete(int userId);
    }
}
