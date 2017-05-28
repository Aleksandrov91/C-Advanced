using System;

namespace Thea_the_Photographer
{
    public class TheaPhotographer
    {
        public static void Main()
        {
            var amountOfPictures = int.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var usefulPictures = Math.Ceiling(amountOfPictures * filterFactor / 100.0);
            var totalFilterTime = filterTime * amountOfPictures;
            var totalUploadTime = (usefulPictures * uploadTime) + totalFilterTime;

            TimeSpan convert = TimeSpan.FromSeconds(totalUploadTime);
            var result = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                convert.Days,
                convert.Hours,
                convert.Minutes,
                convert.Seconds);

            Console.WriteLine(result);
        }
    }
}
