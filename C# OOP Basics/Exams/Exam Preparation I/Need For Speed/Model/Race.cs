using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;

    protected Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new List<Car>();
    }

    public IList<Car> Participants
    {
        get { return this.participants.AsReadOnly(); }
    }

    protected int Length
    {
        get { return this.length; }
    }

    protected string Route
    {
        get { return this.route; }
    }

    protected int PrizePool
    {
        get { return this.prizePool; }
    }

    public void AddParticipant(Car car)
    {
        this.participants.Add(car);
    }

    public virtual string StartRace()
    {
        var winners = this.participants.OrderByDescending(x => this.GetPoints(x)).Take(3).ToList();
        var priceList = this.GetPrise();
        var sb = new StringBuilder();
        sb.AppendLine($"{this.route} - {this.length}");

        for (int i = 0; i < winners.Count(); i++)
        {
            sb.AppendLine(
                $"{i + 1}. {winners[i].Brand} {winners[i].Model} {this.GetPoints(winners[i])}PP - ${priceList[i]}");
        }

        return sb.ToString().Trim();
    }

    protected abstract int GetPoints(Car car);

    protected virtual List<int> GetPrise()
    {
        var prices = new List<int>();
        prices.Add((this.prizePool * 50) / 100);
        prices.Add((this.prizePool * 30) / 100);
        prices.Add((this.prizePool * 20) / 100);

        return prices;
    }
}
