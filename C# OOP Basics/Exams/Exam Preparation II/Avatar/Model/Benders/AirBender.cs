using System.Text;

public class AirBender : Bender
{
    private double aerialIntegirty;

    public AirBender(string name, int power, double aerialIntegirty)
        : base(name, power)
    {
        this.AerialIntegirty = aerialIntegirty;
    }

    public double AerialIntegirty
    {
        get { return this.aerialIntegirty; }
        private set { this.aerialIntegirty = value; }
    }

    public override string ToString()
    {
        return $"###Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegirty:F2}";
    }

    public override double GetWarPoints()
    {
        return this.Power * this.AerialIntegirty;
    }
}
