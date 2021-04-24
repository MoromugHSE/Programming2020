using System;
using System.Xml.Serialization;
using System.Collections.Generic;

public class Bed : Furniture
{
    [XmlElement("pillow")]
    public List<Pillow> pillows;

    public Bed() { }

    public Bed(long id, List<Pillow> pillows) : base(id)
    {
        this.pillows = pillows;
    }
}