namespace _04.Online_Radio_Database
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private const string InvalidArtistName = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException()
            : base(InvalidArtistName)
        {
        }
    }
}
