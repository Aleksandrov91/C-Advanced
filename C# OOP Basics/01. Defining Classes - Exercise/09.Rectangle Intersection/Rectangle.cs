namespace _09.Rectangle_Intersection
{
    public class Rectangle
    {
        private string id;
        private int width;
        private int height;
        private Point leftCorner;

        public Rectangle(string id, int width, int height, Point point)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.leftCorner = point;
        }

        public bool Intersect(Rectangle rectangle)
        {
            return !(this.leftCorner.X > rectangle.leftCorner.X + rectangle.width ||
                   this.leftCorner.X + this.width < rectangle.leftCorner.X ||
                   this.leftCorner.Y > rectangle.leftCorner.Y + rectangle.height ||
                   this.leftCorner.Y + this.height < rectangle.leftCorner.Y);
        }
    }
}
