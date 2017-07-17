using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePower;
    private int acceleration;
    private int suspention;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspention, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsePower = horsePower;
        this.acceleration = acceleration;
        this.suspention = suspention;
        this.durability = durability;
    }

    public string Brand
    {
        get { return this.brand; }
    }

    public string Model
    {
        get { return this.model; }
    }

    public int HorsePower
    {
        get { return this.horsePower; }
        protected set { this.horsePower = value; }
    }

    public int Acceleration
    {
        get { return this.acceleration; }
    }

    public int Suspension
    {
        get { return this.suspention; }
        protected set { this.suspention = value; }
    }

    public int Durability
    {
        get { return this.durability; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
        sb.AppendLine($"{this.horsePower} HP, 100 m/h in {this.acceleration} s");
        sb.AppendLine($"{this.suspention} Suspension force, {this.durability} Durability");

        return sb.ToString().Trim();
    }

    public virtual void TuneCar(int tuneIndex, string addOn)
    {
        this.horsePower += tuneIndex;
        this.suspention += (int)(tuneIndex * 0.5);
    }

    public void DecreaseDurability(int length)
    {
        this.durability -= length * length;
    }
}
