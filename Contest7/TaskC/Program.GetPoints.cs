using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    /// <summary>
    /// Считывает точки в список.
    /// </summary>
    /// <returns>Список точек.</returns>
    private static List<Point> GetPoints()
    {
        List<Point> result = new List<Point>();
        foreach (var unsplitted in File.ReadLines(InputPath))
        {
            string[] unparsed = unsplitted.Split();
            int[] parsed = Array.ConvertAll(unparsed, int.Parse);
            result.Add(new Point(parsed[0], parsed[1], parsed[2]));
        }
        return result;
    }


    /// <summary>
    /// Получает коллекцию уникальных точек.
    /// </summary>
    /// <param name="points">Список исходных точек.</param>
    /// <returns>Коллекция точек.</returns>
    private static HashSet<Point> GetUnique(List<Point> points)
    {
        HashSet<Point> result = new HashSet<Point>();
        foreach (var point in points)
        {
            result.Add(point);
        }
        return result;
    }
}