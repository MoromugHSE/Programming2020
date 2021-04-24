using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

public class SimpleFurnitureSerializer
{
    public void Serialize(List<Furniture> furniture, string outputPath)
    {
        var furnitureArray = furniture.ToArray();
        var xmlSerializer = new XmlSerializer(typeof(Furniture[]));
        using (FileStream fs = File.OpenWrite(outputPath))
        {
            xmlSerializer.Serialize(fs, furnitureArray);
        }
    }
}