using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IntWrapper
{
    public IntWrapper(int number)
    {
        int[][] bellTriangle = new int[rowCount][];
        for (int i = 0; i < rowCount; ++i)
        {
            bellTriangle[i] = new int[i + 1];
            if (i == 0)
            {
                bellTriangle[i][0] = 1;
                continue;
            }
            for (int j = 0; j < i + 1; ++j)
            {
                if (j == 0)
                {
                    bellTriangle[i][j] = bellTriangle[i - 1][i - 1];
                }
                else
                {
                    bellTriangle[i][j] = bellTriangle[i - 1][j - 1] + bellTriangle[i][j - 1];
                }
            }
        }
        return bellTriangle;
    }

    public int FindNumberLength()
    {
        foreach (var row in array)
        {
            foreach( var item in row)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
