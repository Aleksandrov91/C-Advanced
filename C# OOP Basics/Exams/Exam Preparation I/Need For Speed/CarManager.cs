using System.Collections.Generic;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        var car = CarFactory.CreateCar(type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        this.cars[id] = car;
    }

    public string Check(int id)
    {
        return this.cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        var race = RaceFactory.OpenRace(type, length, route, prizePool);

        this.races[id] = race;
    }

    public void Open(int id, string type, int length, string route, int prizePool, int special)
    {
        var race = RaceFactory.OpenRace(type, length, route, prizePool, special);

        this.races[id] = race;
    }

    public void Participate(int carId, int raceId)
    {
        if (this.races[raceId].GetType().Name == "TimeLimitRace" && this.races[raceId].Participants.Count == 1)
        {
            return;
        }

        if (!this.garage.IsParked(carId))
        {
            this.races[raceId].AddParticipant(this.cars[carId]);
        }
    }

    public string Start(int id)
    {
        if (this.races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }

        var result = this.races[id].StartRace();
        this.races.Remove(id);
        return result;
    }

    public void Park(int id)
    {
        foreach (var race in this.races.Values)
        {
            if (race.Participants.Contains(this.cars[id]))
            {
                return;
            }
        }

        this.garage.ParkCar(id, this.cars[id]);
    }

    public void UnPark(int id)
    {
        this.garage.UnParkCar(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        this.garage.TuneCars(tuneIndex, addOn);
    }
}
