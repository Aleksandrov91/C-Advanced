using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private int coins;
    private CoffeeType coffeeType;
    private List<CoffeeType> coffeesSold;

    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
    }

    public void BuyCoffee(string size, string type)
    {
        CoffeeType coffeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        CoffeePrice coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);

        if (this.coins >= (int)coffeePrice)
        {
            this.coffeesSold.Add(this.coffeeType);
            this.coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        Coin insertedCoin = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coins += (int)insertedCoin;
    }

    public IEnumerable<CoffeeType> CoffeesSold
    {
        get { return this.coffeesSold; }
    }
}
