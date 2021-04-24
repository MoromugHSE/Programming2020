using System;
using System.Xml.Serialization;

[XmlInclude(typeof(Bed)), XmlInclude(typeof(Lamp))]
[XmlInclude(typeof(Pillow))]
public abstract class Furniture
{
    public long id;

    public Furniture() { }
    protected Furniture(long id)
    {
        this.id = id;
    }
}