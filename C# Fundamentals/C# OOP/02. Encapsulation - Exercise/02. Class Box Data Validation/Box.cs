namespace _02.Class_Box_Data_Validation
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                this.TrowExceptionIfIsInvalid(value, nameof(this.Length));
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.TrowExceptionIfIsInvalid(value, nameof(this.Width));
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.TrowExceptionIfIsInvalid(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double GetSurfaceArea()
        {
            return 2 * (this.length * this.width) + 2 * (this.length * this.height) + 2 * (this.width * this.height);
        }

        public double GetLateralSurfaceArea()
        {
            return 2 * (this.length * this.height) + 2 * (this.width * this.height);
        }

        public double GetVolume()
        {
            return this.length * this.width * this.height;
        }

        private void TrowExceptionIfIsInvalid(double side, string sideName)
        {
            if (side <= 0)
            {
                throw new ArgumentException($"{sideName} cannot be zero or negative.");
            }
        }
    }
}