using System;

abstract class Editor
{
    protected Editor(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public string Name
    {
        get;
        protected set;
    }

    public int Salary
    {
        get;
        protected set;
    }

    protected string EditHeader(string header)
    {
        return $"{header} {Name}";
    }

    public int CountSalary(string oldStr, string newStr)
    {
        return Math.Abs(oldStr.Length - newStr.Length) * Salary;
    }
}