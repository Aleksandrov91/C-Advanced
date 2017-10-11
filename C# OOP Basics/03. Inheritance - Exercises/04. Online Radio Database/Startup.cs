namespace _04.Online_Radio_Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var playlist = new List<Song>();

            var inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split(new[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    var artistName = input[0];
                    var songName = input[1];
                    if (!int.TryParse(input[2], out int songMinutes) || !int.TryParse(input[3], out int songSeconds))
                    {
                        throw new InvalidSongLengthException();
                    }

                    var song = new Song(artistName, songName, songMinutes, songSeconds);
                    playlist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Songs added: {playlist.Count}");
            var totalSeconds = playlist.Sum(x => x.Seconds);
            var convertedMinutes = playlist.Sum(x => x.Minutes) * 60;
            var totalLenght = totalSeconds + convertedMinutes;

            TimeSpan t = TimeSpan.FromSeconds(totalLenght);

            string answer = string.Format("{0:D1}h {1:D1}m {2:D1}s", 
                t.Hours,
                t.Minutes,
                t.Seconds);

            Console.WriteLine($"Playlist length: {answer}");
        }
    }
}
