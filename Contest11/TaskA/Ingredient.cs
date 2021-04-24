using System;
using System.Runtime.Serialization;

[DataContract]
[KnownType(typeof(Vegetable)), KnownType(typeof(Meat))]
public class Ingredient : IComparable<Ingredient>
{
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    protected int TimeToCook { get; set; }

    public Ingredient(string name, int timeToCook)
    {
        Name = name;
        TimeToCook = timeToCook;
    }

    public int CompareTo(Ingredient a)
    {
        return -TimeToCook.CompareTo(a.TimeToCook);
    }

    public override string ToString()
    {
        return Name;
    }
}