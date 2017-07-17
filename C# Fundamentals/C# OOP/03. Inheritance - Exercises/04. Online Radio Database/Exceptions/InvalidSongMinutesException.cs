namespace _04.Online_Radio_Database
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string InvalidSongMinutes = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException()
            : base(InvalidSongMinutes)
        {
        }
    }
}