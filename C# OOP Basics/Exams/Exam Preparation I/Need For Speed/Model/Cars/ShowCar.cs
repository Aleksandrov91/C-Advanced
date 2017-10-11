using System.Text;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspention, int durability)
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspention, durability)
    {
    }

    public override void TuneCar(int tuneIndex, string addOn)
    {
        this.stars += tuneIndex;
        base.TuneCar(tuneIndex, addOn);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"{this.stars} *");

        return sb.ToString().Trim();
    }
}
