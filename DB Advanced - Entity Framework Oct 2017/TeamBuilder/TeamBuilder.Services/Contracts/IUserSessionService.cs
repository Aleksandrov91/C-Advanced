namespace TeamBuilder.Services.Contracts
{
    using TeamBuilder.DTO;
    using TeamBuilder.Models;

    public interface IUserSessionService
    {
        User User { get; }

        UserDto Login(string username, string password);

        void Logout();

        bool IsLoggedIn();
    }
}
