using System.Text;

public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public double GroundSaturation
    {
        get { return this.groundSaturation; }
        private set { this.groundSaturation = value; }
    }

    public override string ToString()
    {
        return $"###Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.GroundSaturation:F2}";
    }

    public override double GetWarPoints()
    {
        return this.Power * this.GroundSaturation;
    }
}
