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

        return Math.Round(gpaSum / students.Count, 2);
    }


    public static void WriteStudentsWithGpaNoLessThanAverage(List<Student> students, string path, double gpa)
    {
        using (StreamWriter sr = File.CreateText(path))
        {
            sr.WriteLine(gpa);
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