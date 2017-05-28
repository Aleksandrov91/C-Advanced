using System;
using System.Linq;

namespace Rectangle_Position
{
    public class RectanglePosition
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstRectangle = new Rectangle
            {
                Left = firstLine[0],
                Top = firstLine[1],
                Width = firstLine[2],
                Height = firstLine[3]
            };

            var secondRectangle = new Rectangle
            {
                Left = secondLine[0],
                Top = secondLine[1],
                Width = secondLine[2],
                Height = secondLine[3]
            };

            Console.WriteLine(IsInside(firstRectangle, secondRectangle) ? "Inside" : "Not Inside");
        }

        public static bool IsInside(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            if (firstRectangle.Left >= secondRectangle.Left && firstRectangle.Top >= secondRectangle.Top
                && firstRectangle.Right <= secondRectangle.Right && firstRectangle.Bottom >= secondRectangle.Bottom)
            {
                return true;
            }

            return false;
        }
    }
}
