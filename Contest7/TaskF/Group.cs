using System;


public class Group
{
    Student[] students;
    public Group(Student[] students)
    {
        Students = students;
    }

    public Student[] Students
    {
        get => students;
        private set
        {
            if (value.Length < 5)
            {
                throw new ArgumentException("Incorrect group");
            }
            students = value;
        }
    }

    public int IndexOfMaxGrade()
    {
        int maxGrade = -1;
        int maxPos = -1;
        for (int i = 0; i < students.Length; ++i)
        {
            if (students[i].Mark > maxGrade)
            {
                maxPos = i;
                maxGrade = students[i].Mark;
            }
        }
        return maxPos;
    }

    public int IndexOfMinGrade()
    {
        int minGrade = 11;
        int minPos = -1;
        for (int i = 0; i < students.Length; ++i)
        {
            if (students[i].Mark < minGrade)
            {
                minPos = i;
                minGrade = students[i].Mark;
            }
        }
        return minPos;
    }

    public Student this[int index]
    {
        get => students[index];
    }
}