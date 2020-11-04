using System;
using System.Collections.Generic;

internal static class Program
{

    private static int[] TransformStringArrayIntoIntegerArray(string[] stringArray)
    {
        int[] resultArray = new int[stringArray.Length];
        for (int i = 0; i < resultArray.Length; ++i)
        {
            resultArray[i] = int.Parse(stringArray[i]);
        }
        return resultArray;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int length = matrix.GetLength(0);
        for (int i = 0; i < length; ++i)
        {
            for (int j = 0; j < length; ++j)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void Main(string[] args)
    {
        string[] splittedInput = Console.ReadLine().Split(',');
        int[] parsedInput = TransformStringArrayIntoIntegerArray(splittedInput);
        int matrixLength = parsedInput.Length;
        int[,] matrix = new int[matrixLength, matrixLength];
        for (int i = 0; i < matrixLength; ++i)
        {
            for (int j = 0; j < matrixLength; ++j)
            {
                matrix[i, j] = parsedInput[(i + j) % matrixLength];
            }
        }
        PrintMatrix(matrix);
    }
}