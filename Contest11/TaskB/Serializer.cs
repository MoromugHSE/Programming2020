using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public static class Serializer
{
    private static List<Student> students = new List<Student>();

    public static void ReadStudents(string path)
    {
        using (var sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                var studentInfo = sr.ReadLine();
                students.Add(Student.Create(studentInfo));
            }
        }
    }

    public static void SerializeStudents(string path)
    {
        var bf = new BinaryFormatter();
        using (var fs = File.OpenWrite(path))
        {
            bf.Serialize(fs, students);
        }
    }
}