using System;
using System.Xml.Serialization;

[XmlInclude(typeof(Ash)), XmlInclude(typeof(Oak))]
public class Tree : IComparable<Tree>
{
    public int height;
    public int age;

    public Tree()
    {
    }

    public Tree(int height, int age)
    {
        this.height = height;
        this.age = age;
    }

    public int CompareTo(Tree tree)
    {
        return this.height.CompareTo(tree.height);
    }

    public override string ToString()
    {
        return $"height:{height} age:{age}";
    }
}