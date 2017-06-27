namespace Rectangle_Position
{
    public class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Area()
        {
            return Width * Height;
        }
    }
}
