using System.Linq;
using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;

    public TimeLimitRace(int length, string route, int prizePool, int goldTime)
        : base(length, route, prizePool)
    {
        this.goldTime = goldTime;
    }

    public override string StartRace()
    {
        var driverResult = this.Participants.OrderByDescending(x => this.GetPoints(x)).FirstOrDefault();
        var driverPoints = this.GetPoints(driverResult);
        var wonPrice = 0;

        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.AppendLine($"{driverResult.Brand} {driverResult.Model} - {driverPoints} s.");

        if (driverPoints <= this.goldTime)
        {
            wonPrice = this.PrizePool;
            sb.AppendLine($"Gold Time, ${wonPrice}.");
        }
        else if (driverPoints <= this.goldTime + 15)
        {
            wonPrice = (this.PrizePool * 50) / 100;
            sb.AppendLine($"Silver Time, ${wonPrice}.");
        }
        else
        {
            wonPrice = (this.PrizePool * 30) / 100;
            sb.AppendLine($"Bronze Time, ${wonPrice}.");
        }

        return sb.ToString();
    }

    protected override int GetPoints(Car car)
    {
        return this.Length * ((car.HorsePower / 100) * car.Acceleration);
    }
}
