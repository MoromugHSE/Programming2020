using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

partial class Program
{
    static bool TryParseVectorFromFile(string filename, out int[] vector)
    {
        string[] unparsedInput = File.ReadAllText(filename).Split();
        vector = new int[unparsedInput.Length];
        bool areAllElementsCorrect = true;
        for (int i=0; i < vector.Length; ++i)
        {
            areAllElementsCorrect &= int.TryParse(unparsedInput[i], out vector[i]);
        }
        return areAllElementsCorrect;
    }

    static int[,] MakeMatrixFromVector(int[] vector)
    {
        int length = vector.Length;
        int[,] matrix = new int[length, length];
        for (int i=0; i < length; ++i)
        {
            for (int j=0; j < length; ++j)
            {
                matrix[i, j] = vector[i] * vector[j];
            }
        }
        return matrix;
    }

    static void WriteMatrixToFile(int[,] matrix, string filename)
    {
        StringBuilder resultString = new StringBuilder();
        for (int i=0; i < matrix.GetLength(0); ++i)
        {
            if (i != 0)
            {
                resultString.Append(Environment.NewLine);
            }
            resultString.Append(matrix[i, 0].ToString());
            for (int j=1; j < matrix.GetLength(1); ++j)
            {
                resultString.Append($" {matrix[i, j]}");
            }
        }
        File.WriteAllText(filename, resultString.ToString());
    }
}
