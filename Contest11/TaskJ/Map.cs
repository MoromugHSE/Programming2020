using System;
using System.Collections.Generic;

public class Map<TKey, TValue>
{
    private List<(TKey, TValue)> map;

    public Map()
    {
        map = new List<(TKey, TValue)>();
    }

    public void Add(TKey key, TValue value)
    {
        if (ContainsKey(key))
            throw new ArgumentException(
                $"An item with the same key has already been added. Key: {key}");
        map.Add((key, value));
    }

    public TValue this[TKey key]
    {
        get
        {
            if (!ContainsKey(key))
                throw new ArgumentException(
                    $"The given key '{key}' was not present in the map.");
            return map.Find(x => x.Item1.Equals(key)).Item2;
        }
    }

    public bool Remove(TKey key)
    {
        var item = map.Find(x => x.Item1.Equals(key));
        return map.Remove(item);
    }

    public int Count => map.Count;

    public bool ContainsKey(TKey key)
    {
        return map.Exists(x => x.Item1.Equals(key));
    }
}