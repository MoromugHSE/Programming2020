using System;
using System.IO;
using System.Text;

internal class Matrix
{
    int[,] matrix;

    public Matrix(string filename)
    {
        string[] rowedUnsplittedMatrix = File.ReadAllLines(filename);
        string[][] unparsedMatrix = new string[rowedUnsplittedMatrix.Length][];
        for (int i=0; i < unparsedMatrix.Length; ++i)
        {
            unparsedMatrix[i] = rowedUnsplittedMatrix[i].Split(';');
        }
        matrix = new int[unparsedMatrix.Length, unparsedMatrix[0].Length];
        for (int i=0; i < matrix.GetLength(0); ++i)
        {
            for (int j=0; j < matrix.GetLength(1); ++j)
            {
                matrix[i, j] = int.Parse(unparsedMatrix[i][j]);
            }
        }
    }

    public int SumOffEvenElements
    {
        get
        {
            int sum = 0;
            foreach (var x in matrix)
            {
                if (x%2 == 0)
                {
                    sum += x;
                }
            }
            return sum;
        }
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i=0; i < matrix.GetLength(0); ++i)
        {
            for (int j=0; j < matrix.GetLength(1); ++j)
            {
                if (j != 0)
                {
                    sb.Append('\t');
                }
                sb.Append(matrix[i, j]);
            }
            sb.Append(Environment.NewLine);
        }
        return sb.ToString();
    }
}