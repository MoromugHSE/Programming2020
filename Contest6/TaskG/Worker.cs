using System;

public class Worker
{
    Apple[] apples;
    public Worker(Apple[] apples)
    {
        double[] weights = new double[apples.Length];
        for (int i = 0; i < weights.Length; ++i)
        {
            weights[i] = apples[i].Weight;
        }
        Array.Sort(weights, apples);
        this.apples = apples;
    }

    public Apple[] GetSortedApples()
    {
        return apples;
    }
}