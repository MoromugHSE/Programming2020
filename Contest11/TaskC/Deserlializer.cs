using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Deserializer
{
    public static List<Student> DeserializeStudents(string path)
    {
        List<Student> students = new List<Student>();
        var bf = new BinaryFormatter();
        using (FileStream fs = File.OpenRead(path))
        {
            students = (List<Student>)bf.Deserialize(fs);
        }

        return students;
    }
}