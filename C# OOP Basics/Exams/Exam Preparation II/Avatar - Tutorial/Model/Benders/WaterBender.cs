public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double waterClarity)
        : base(name, power)
    {
        this.waterClarity = waterClarity;
    }

    public double WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }

    public override double GetPower()
    {
        return this.Power * this.WaterClarity;
    }

    public override string ToString() => $"{base.ToString()}, Water Clarity: {this.WaterClarity:F2}";
}
