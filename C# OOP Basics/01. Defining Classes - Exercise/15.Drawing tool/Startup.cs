namespace _15.Drawing_tool
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var shapeType = Console.ReadLine();

            if (shapeType == "Square")
            {
                var width = int.Parse(Console.ReadLine());
                Square square = new Square(width);
                square.DrawFigure();
            }
            else
            {
                var width = int.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(width, height);
                rectangle.DrawFigure();
            }
        }
    }
}
