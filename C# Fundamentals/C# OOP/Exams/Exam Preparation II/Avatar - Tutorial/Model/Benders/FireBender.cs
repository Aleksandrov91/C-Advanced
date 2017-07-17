public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.heatAggression = heatAggression;
    }

    public double HeatAggression
    {
        get { return this.heatAggression; }
        set { this.heatAggression = value; }
    }

    public override double GetPower()
    {
        return this.Power * this.HeatAggression;
    }

    public override string ToString() => $"{base.ToString()}, Heat Aggression: {this.HeatAggression:F2}";
}
