using System;
using static System.Math;
using System.Text;

public class Snowflake
{
    int widthAndHeight;
    int raysCount;
    char[][] snowflake;

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
                !IsPowerOfTwo(value))
            {
                throw new ArgumentException("Incorrect input");
            }
            raysCount = value;
        }
    }

    private bool IsPowerOfTwo(int value)
    {
        while (value > 1)
        {
            if (value % 2 != 0)
            {
                return false;
            }
            value /= 2;
        }
        return true;
    }

    public override string ToString()
    {
        StringBuilder resultBuilder = new StringBuilder();
        for (int i = 0; i < widthAndHeight; ++i)
        {
            string row = string.Join(' ', snowflake[i]);
            resultBuilder.AppendLine(row);
        }
        return resultBuilder.ToString();
    }

    private void MakeSnowFlake()
    {
        snowflake = new char[widthAndHeight][];
        for (int i = 0; i < widthAndHeight; ++i)
        {
            snowflake[i] = new char[widthAndHeight];
            for (int j = 0; j < widthAndHeight; ++j)
            {
                if (i == widthAndHeight / 2 || j == widthAndHeight / 2)
                {
                    snowflake[i][j] = '*';
                }
                else if (raysCount > 4 && (i == j || i + j == widthAndHeight - 1))
                {
                    snowflake[i][j] = '*';
                }
                else
                {
                    snowflake[i][j] = ' ';
                }
            }
        }
        int otherRays = raysCount - 8;
        int change = 2;
        (int i, int j) center = (widthAndHeight / 2, widthAndHeight / 2);
        while (otherRays > 0 && change <= widthAndHeight / 2)
        {
            DrawRay((center.i, center.j - change), (-1, -1));
            DrawRay((center.i, center.j - change), (1, -1));
            DrawRay((center.i + change, center.j), (1, -1));
            DrawRay((center.i + change, center.j), (1, 1));
            DrawRay((center.i, center.j + change), (1, 1));
            DrawRay((center.i, center.j + change), (-1, 1));
            DrawRay((center.i - change, center.j), (-1, 1));
            DrawRay((center.i - change, center.j), (-1, -1));
            otherRays -= 8;
            change += 2;
        }
    }

    private void DrawRay((int, int) point, (int, int) delta)
    {
        int i = point.Item1;
        int j = point.Item2;
        while (i >= 0 && i < widthAndHeight && j >= 0 && j < widthAndHeight)
        {
            snowflake[i][j] = '*';
            i += delta.Item1;
            j += delta.Item2;
        }
    }
}