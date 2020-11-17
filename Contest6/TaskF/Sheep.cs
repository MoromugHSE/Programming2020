
using System;

public class Sheep
{
    private string name;
    private int id;
    private string sound;

    public Sheep(int id, string name, string sound)
    {
        if (id <= 0 || id >= 1000)
        {
            throw new ArgumentException("Incorrect input");
        }
        this.name = name;
        this.id = id;
        this.sound = sound;
    }

    public string Name => name;

    public string Sound => sound;

    public int Id => id;

    public override string ToString()
    {
        return $"[{id}-{name}]: {sound}...{sound}";
    }

}
