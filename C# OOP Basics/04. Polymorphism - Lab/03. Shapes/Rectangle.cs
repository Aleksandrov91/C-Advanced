using System;

public class Rectangle : Shape
{
    private double heigth;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Heigth = height;
        this.Width = width;
    }

    public double Heigth
    {
        get { return this.heigth; }
        private set { this.heigth = value; }
    }

    public double Width
    {
        get { return this.width; }
        private set { this.width = value; }
    }

    public override double CalculatePerimeter()
    {
        return 2 * (this.Heigth + this.Width);
    }

    public override double CalculateArea()
    {
        return this.Heigth * this.Width;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
