using System;

public partial class Program
{
    static bool ParseArrayFromLine(string line, out int[] arr)
    {
        string[] unparsedLine = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
        arr = new int[unparsedLine.Length];
        for (int i=0; i < arr.Length; ++i)
        {
            if (!int.TryParse(unparsedLine[i], out arr[i]))
            {
                return false;
            }
        }
        return true;
    }

    private static void Merge(int[] arr, int left, int right, int mid)
    {
        int[] tempArr = new int[right - left];
        int leftInd = left;
        int rightInd = mid;
        int tempInd = 0;
        while (leftInd < mid && rightInd < right)
        {
            if (arr[leftInd] < arr[rightInd])
            {
                tempArr[tempInd++] = arr[leftInd++];
            }
            else
            {
                tempArr[tempInd++] = arr[rightInd++];
            }
        }
        while (leftInd < mid)
        {
            tempArr[tempInd++] = arr[leftInd++];
        }
        while (rightInd < right)
        {
            tempArr[tempInd++] = arr[rightInd++];
        }
        Array.Copy(tempArr, 0, arr, left, tempInd);
    }
}