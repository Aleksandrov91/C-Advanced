using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CircuitRace : CasualRace
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps)
        : base(length, route, prizePool)
    {
        this.laps = laps;
    }

    public override string StartRace()
    {
        for (int i = 0; i < this.laps; i++)
        {
            this.Participants.ToList().ForEach(p => p.DecreaseDurability(this.Length));
        }

        var winners = this.Participants.OrderByDescending(x => GetPoints(x)).Take(4).ToList();
        var priceList = this.GetPrise();
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length * this.laps}");

        for (int i = 0; i < winners.Count(); i++)
        {
            sb.AppendLine(
                $"{i + 1}. {winners[i].Brand} {winners[i].Model} {this.GetPoints(winners[i])}PP - ${priceList[i]}");
        }

        return sb.ToString().Trim();
    }

    protected override List<int> GetPrise()
    {
        var prices = new List<int>();
        prices.Add((this.PrizePool * 40) / 100);
        prices.Add((this.PrizePool * 30) / 100);
        prices.Add((this.PrizePool * 20) / 100);
        prices.Add((this.PrizePool * 10) / 100);

        return prices;
    }
}
