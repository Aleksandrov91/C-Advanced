namespace _01.Class_Box
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            return 2 * (this.lenght * this.width) + 2 * (this.lenght * this.height) + 2 * (this.width * this.height);
        }

        public double GetLateralSurfaceArea()
        {
            return 2 * (this.lenght * this.height) + 2 * (this.width * this.height);
        }

        public double GetVolume()
        {
            return this.lenght * this.width * this.height;
        }
    }
}