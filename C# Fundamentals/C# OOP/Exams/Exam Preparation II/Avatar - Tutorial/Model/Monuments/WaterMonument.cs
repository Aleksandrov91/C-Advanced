public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity)
        : base(name)
    {
        this.waterAffinity = waterAffinity;
    }

    public int WaterAffinity
    {
        get { return this.waterAffinity; }
        set { this.waterAffinity = value; }
    }

    public override int GetAffinity() => this.WaterAffinity;

    public override string ToString() => $"{base.ToString()}, Water Affinity: {this.WaterAffinity}";
}
