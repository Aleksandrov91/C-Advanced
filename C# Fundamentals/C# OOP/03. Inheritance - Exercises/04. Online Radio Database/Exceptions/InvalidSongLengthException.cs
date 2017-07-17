namespace _04.Online_Radio_Database
{
    public class InvalidSongLengthException : InvalidSongException
    {
        private const string InvalidSongLenght = "Invalid song length.";

        public InvalidSongLengthException()
            : base(InvalidSongLenght)
        {
        }

        protected InvalidSongLengthException(string exception)
            : base(exception)
        {
        }
    }
}