using System;

namespace Thea_The_Photographer
{
    public class TheaThePhotographer
    {
        public static void Main()
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            double usefulPictures = Math.Ceiling(numberOfPictures * (filterFactor / 100.0));
            long totalPicturesTime = numberOfPictures * filterTime;
            double totalUploadTime = totalPicturesTime + (usefulPictures * uploadTime);
            TimeSpan convertedTime = TimeSpan.FromSeconds(totalUploadTime);
            string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                convertedTime.Days,
                convertedTime.Hours,
                convertedTime.Minutes,
                convertedTime.Seconds);
            Console.WriteLine(answer);
        }
    }
}
