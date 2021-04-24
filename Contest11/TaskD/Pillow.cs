using System;
using System.Xml.Serialization;

public class Pillow : Furniture
{
    public string isRuined;

    public Pillow() { }

    public Pillow(long id, bool isRuined) : base(id)
    {
        this.isRuined = isRuined ? "Yes" : "No";
    }
}