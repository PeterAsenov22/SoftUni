using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private List<CoffeeType> coffeeSold;

    public CoffeeMachine()
    {
        this.Coins = 0;
        this.coffeeSold = new List<CoffeeType>();
    }

    private int Coins { get; set; }

    public IEnumerable<CoffeeType> CoffeesSold
    {
        get { return this.coffeeSold; }
    }

    public void BuyCoffee(string size, string type)
    {
        var wantedSize = (CoffeePrice) Enum.Parse(typeof(CoffeePrice), size);
        var wantedType = (CoffeeType) Enum.Parse(typeof(CoffeeType), type);

        if (this.Coins >= (int) wantedSize)
        {
            this.coffeeSold.Add(wantedType);
            this.Coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        var coinInserted = (Coin) Enum.Parse(typeof(Coin), coin);
        this.Coins += (int) coinInserted;
    }
}
