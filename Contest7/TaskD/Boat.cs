using System;

class Boat
{
    protected int pricePerKilo;

    public Boat(int value, bool isAtThePort)
    {
        pricePerKilo = value;
        IsAtThePort = isAtThePort;
    }

    public bool IsAtThePort
    {
        get;
        private set;
    }

    public int CountCost(int weight)
    {
        return weight * pricePerKilo;
    }
}


