using System.Text;

public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public int WaterAffinity
    {
        get { return this.waterAffinity; }
        private set { this.waterAffinity = value; }
    }

    public override string ToString()
    {
        return $"###Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}";
    }

    public override int MonumentBonus()
    {
        return this.WaterAffinity;
    }
}
