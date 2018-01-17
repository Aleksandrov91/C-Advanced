namespace TeamBuilder.Services
{
    using AutoMapper;
    using TeamBuilder.DTO;
    using TeamBuilder.Models;
    using TeamBuilder.Services.Contracts;

    public class UserSessionService : IUserSessionService
    {
        private readonly IUserService userService;

        public UserSessionService(IUserService userService)
        {
            this.userService = userService;
        }

        public User User { get; private set; }

        public bool IsLoggedIn()
        {
            return this.User != null;
        }

        public UserDto Login(string username, string password)
        {
            this.User = this.userService.ByUserNameAndPassword(username, password);

            UserDto userDto = Mapper.Map<UserDto>(this.User);

            return userDto;
        }

        public void Logout()
        {
            this.User = null;
        }
    }
}
