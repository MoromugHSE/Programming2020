using System;

internal class ChristmasArray : BaseArray
{
    public ChristmasArray(int[] array) : base(array)
    {
        Array.Sort(this.array);
    }

    public override int this[int number]
    {
        get
        {
            int index = BinarySearch(array, number);
            if (index < 0)
            {
                throw new ArgumentException("Number does not exist.");
            }
            return array[index];
        }
    }

    public static int BinarySearch(int[] arr, int val)
    {
        int l = -1;
        int r = arr.Length;
        int m;
        while (r - l > 1)
        {
            m = (l + r) / 2;
            if (arr[m] >= val)
            {
                r = m;
            }
            else
            {
                l = m;
            }
        }
        return l;
    }

    public override double GetMetric()
    {
        string arrString = string.Join("", array);
        int counter = arrString.Length;
        int sixes = arrString.Split('6').Length - 1;
        return (double)sixes / counter;
    }
}