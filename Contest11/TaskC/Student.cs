using System;
using System.Collections.Generic;

[Serializable]
public class Student
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public int GroupNumber { get; private set; }
    public List<int> Grades { get; private set; }

    public Student(string name, string lastName, int groupNumber, List<int> grades)
    {
        Name = name;
        LastName = lastName;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    public static Student Create(string studentInfo)
    {
        string[] splitted = studentInfo.Split();
        string name = splitted[0];
        string lastName = splitted[1];
        int groupNumber = int.Parse(splitted[2]);
        var grades = new List<int>();
        for (int i = 3; i < splitted.Length; ++i)
        {
            grades.Add(int.Parse(splitted[i]));
        }

        return new Student(name, lastName, groupNumber, grades);
    }

    public double GetGpa()
    {
        int gradeSum = 0;
        foreach (var grade in Grades)
        {
            gradeSum += grade;
        }

        return (double) gradeSum / Grades.Count;
    }

    public override string ToString()
    {
        return $"{Name} {LastName} {GroupNumber}";
    }
}