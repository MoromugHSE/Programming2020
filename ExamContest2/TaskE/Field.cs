using System;
using System.Text;

public class Field
{
    private int[][] matrix;

    public Field(int[][] matrix)
    {
        this.matrix = matrix;
    }

    public void FillIn(string fillType)
    {
        switch (fillType)
        {
            case "left to right":
                {
                    for (int i=0; i < matrix.Length; ++i)
                    {
                        matrix[i] = new int[matrix.Length];
                        for (int j = 0; j < matrix.Length; ++j)
                        {
                            matrix[i][j] = i + j + 1;
                        }
                    }
                    break;
                }
            case "right to left":
                {
                    for (int i = 0; i < matrix.Length; ++i)
                    {
                        matrix[i] = new int[matrix.Length];
                        for (int j = 0; j < matrix.Length; ++j)
                        {
                            matrix[i][j] = i + matrix.Length - j;
                        }
                    }
                    break;
                }
            default:
                {
                    throw new ArgumentException("Incorrect input");
                }
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i=0; i < matrix.Length; ++i)
        {
            string row = String.Join(" ", matrix[i]);
            sb.AppendLine(row);
        }
        return sb.ToString();
    }
}