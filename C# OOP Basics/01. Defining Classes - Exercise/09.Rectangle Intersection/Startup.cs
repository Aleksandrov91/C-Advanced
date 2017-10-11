namespace _09.Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rectangles = new Dictionary<string, Rectangle>();

            var numberOfRectangles = int.Parse(inputLine[0]);
            var intersectionCheck = int.Parse(inputLine[1]);

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var rectangleData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var id = rectangleData[0];
                var width = int.Parse(rectangleData[1]);
                var height = int.Parse(rectangleData[2]);
                var coordinatesX = double.Parse(rectangleData[3]);
                var coordinatesY = double.Parse(rectangleData[4]);
                var leftCorner = new Point(coordinatesX, coordinatesY);

                rectangles.Add(id, new Rectangle(id, width, height, leftCorner));
            }

            for (int i = 0; i < intersectionCheck; i++)
            {
                var rectangleId = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine(rectangles[rectangleId[0]].Intersect(rectangles[rectangleId[1]]).ToString().ToLower());
            }
        }
    }
}
