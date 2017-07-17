namespace _04.Online_Radio_Database
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string InvalidSongSeconds = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException()
            : base(InvalidSongSeconds)
        {
        }
    }
}