using System.Collections.Generic;

public class Garage
{
    private Dictionary<int, Car> parkedCars;

    public Garage()
    {
        this.parkedCars = new Dictionary<int, Car>();
    }

    public void ParkCar(int id, Car car)
    {
        this.parkedCars[id] = car;
    }

    public void UnParkCar(int id)
    {
        this.parkedCars.Remove(id);
    }

    public bool IsParked(int id)
    {
        if (this.parkedCars.ContainsKey(id))
        {
            return true;
        }

        return false;
    }

    public void TuneCars(int tuneIndex, string addOn)
    {
        foreach (var car in this.parkedCars)
        {
            car.Value.TuneCar(tuneIndex, addOn);
        }
    }
}
