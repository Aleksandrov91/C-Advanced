using AutoMapper;
using System;
using System.Linq;
using TeamBuilder.Data;
using TeamBuilder.DTO;
using TeamBuilder.Models;
using TeamBuilder.Models.Enums;
using TeamBuilder.Services.Contracts;

namespace TeamBuilder.Services
{
    public class UserService : IUserService
    {
        private readonly TeamBuilderContext context;

        public UserService(TeamBuilderContext context)
        {
            this.context = context;
        }

        public bool IsUserExisting(string username)
        {
            bool isUserExists = this.context.Users
                .Any(u => u.Username == username);

            return isUserExists;
        }

        public User ByUserNameAndPassword(string username, string password)
        {
            User user = this.context.Users
                .Where(u => u.Username == username && u.Password == password && u.IsDeleted == false)
                .SingleOrDefault();

            return user;
        }

        public UserDto Register(string username, string password, string firstName, string lastName, int age, Gender gender)
        {
            User user = new User
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Gender = gender
            };

            this.context.Users.Add(user);
            this.context.SaveChanges();

            UserDto userDto = Mapper.Map<UserDto>(user);

            return userDto;
        }

        public void Delete(int userId)
        {
            User user = this.context.Users.Find(userId);

            this.context.Users.Remove(user);
        }
    }
}
