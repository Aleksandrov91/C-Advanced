namespace _04.Online_Radio_Database
{
    using System;

    public class InvalidSongException : Exception
    {
        private const string InvalidSong = "Invalid song.";

        public InvalidSongException()
            : this(InvalidSong)
        {
        }

        protected InvalidSongException(string exception)
            : base(exception)
        {
        }
    }
}
