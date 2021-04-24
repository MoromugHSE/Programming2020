using System;
using System.Collections.Generic;
using System.IO;

public static class Analytics
{
    public static double FindGpa(List<Student> students)
    {
        double gpaSum = 0;
        foreach (var student in students)
        {
            gpaSum += student.GetGpa();
        }

        return gpaSum / students.Count;
    }


    public static void WriteStudentsWithGpaNoLessThanAverage(List<Student> students, string path, double gpa)
    {
        using (StreamWriter sr = File.CreateText(path))
        {
            sr.WriteLine(Math.Round(gpa, 2));
            foreach (var student in students)
            {
                if (!(student.GetGpa() < gpa))
                {
                    sr.WriteLine(student);
                }
            }
        }
    }
}