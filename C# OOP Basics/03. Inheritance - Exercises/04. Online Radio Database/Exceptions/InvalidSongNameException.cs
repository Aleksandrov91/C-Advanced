namespace _04.Online_Radio_Database
{
    public class InvalidSongNameException : InvalidSongException
    {
        private const string InvalidSongName = "Song name should be between 3 and 30 symbols.";

        public InvalidSongNameException()
            : base(InvalidSongName)
        {
        }
    }
}