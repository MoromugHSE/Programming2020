using System;
public class Lamp : Furniture
{
    public double lifeTime;

    public Lamp() { }

    public Lamp(long id, TimeSpan lifeTime) : base(id)
    {
        this.lifeTime = lifeTime.TotalSeconds;
    }
}