using System;

public class MartianInt
{
    private int value;
    private static int count = 0;
    
    public MartianInt(int value)
    {
        this.value = value;
    }
    
    public static explicit operator int (MartianInt a)
    {
        return a.value + count++;
    }

    public static implicit operator MartianInt(int a)
    {
        int value = a - count++;
        if (value < 0)
            throw new ArgumentException("Value is negative");
        return new MartianInt(value);
    }

    public int Value => value;
}