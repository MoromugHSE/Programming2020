using System;
using static System.Math;
using System.Text;

public class Snowflake
{
    int widthAndHeight;
    int raysCount;
    char[,] snowflake;

    public Snowflake(int widthAndHeight, int raysCount)
    {
        WidthAndHeight = widthAndHeight;
        RaysCount = raysCount;
        MakeSnowFlake();
    }

    public int WidthAndHeight
    {
        get => widthAndHeight;
        private set
        {
            if (value < 0 || value % 2 == 0)
            {
                throw new ArgumentException("Incorrect input");
            }
            widthAndHeight = value;
        }
    }

    public int RaysCount
    {
        get => raysCount;
        private set
        {
            if (value < 4 ||
                Abs(Pow(2, (int)Log2(value)) - value) > 1e-8)
            {
                throw new ArgumentException("Incorrect input");
            }
            raysCount = value;
        }
    }

    public override string ToString()
    {
        StringBuilder resultBuilder = new StringBuilder();
        for (int i = 0; i < widthAndHeight; ++i)
        {
            StringBuilder rowBuilder = new StringBuilder(snowflake[i, 0].ToString());
            for (int j = 1; j < widthAndHeight; ++j)
            {
                rowBuilder.Append($" {snowflake[i, j]}");
            }
            resultBuilder.AppendLine(rowBuilder.ToString());
        }
        return resultBuilder.ToString();
    }

    private void MakeSnowFlake()
    {
        snowflake = new char[widthAndHeight, widthAndHeight];
        for (int i = 0; i < widthAndHeight; ++i)
        {
            for (int j = 0; j < widthAndHeight; ++j)
            {
                if (i == widthAndHeight / 2 || j == widthAndHeight / 2
                    || (i + j) % 2 == 0)
                {
                    snowflake[i, j] = '*';
                }
                else
                {
                    snowflake[i, j] = ' ';
                }
            }
        }
    }
}