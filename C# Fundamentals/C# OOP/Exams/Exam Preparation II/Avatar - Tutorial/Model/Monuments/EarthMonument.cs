public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.earthAffinity = earthAffinity;
    }

    public int EarthAffinity
    {
        get { return this.earthAffinity; }
        set { this.earthAffinity = value; }
    }

    public override int GetAffinity() => this.EarthAffinity;

    public override string ToString() => $"{base.ToString()}, Earth Affinity: {this.EarthAffinity}";
}
