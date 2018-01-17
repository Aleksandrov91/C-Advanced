namespace PhotoShare.Client.Sessions
{
    using PhotoShare.Models;

    public static class CurrentSession
    {
        public static User LoggedUser { get; set; }

        public static bool IsAuthorised => LoggedUser != null;
    }
}
