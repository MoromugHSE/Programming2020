using System;
using System.Collections.Generic;

public class Grassland
{
    private List<Sheep> sheeps;

    public Grassland(List<Sheep> sheeps)
    {
        this.sheeps = sheeps;
    }

    public List<Sheep> GetEvenSheeps()
    {
        List<Sheep> result = new List<Sheep>();
        foreach (var sheep in sheeps)
        {
            if ((sheep.Id & 1) == 0)
            {
                result.Add(sheep);
            }
        }
        return result;
    }

    public List<Sheep> GetOddSheeps()
    {
        List<Sheep> result = new List<Sheep>();
        foreach (var sheep in sheeps)
        {
            if ((sheep.Id & 1) == 1)
            {
                result.Add(sheep);
            }
        }
        return result;
    }

    public List<Sheep> GetSheepsByContainsName(string name)
    {
        List<Sheep> result = new List<Sheep>();
        foreach (var sheep in sheeps)
        {
            if (sheep.Name.ToLower().Contains(name.ToLower()))
            {
                result.Add(sheep);
            }
        }
        return result;
    }
}
