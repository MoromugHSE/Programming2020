using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class RandomProxy
{
    StreamWriter log;
    Dictionary<string, int> users = new Dictionary<string, int>();
    Random rnd = new Random(1579);

    public RandomProxy(StreamWriter log)
    {
        this.log = log;
    }

    public void Register(string login, int age)
    {
        if (users.ContainsKey(login))
        {
            throw new ArgumentException(
                $"User {login}: login is already registered");
        }
        users[login] = age;
        log.WriteLine($"User {login}: login registered");
    }

    public int Next(string login)
    {
        if (!users.ContainsKey(login))
        {
            throw new ArgumentException(
                $"User {login}: login is not registered");
        }
        if (users[login] < 20)
        {
            return Next(login, 1000);
        }
        return Next(login, int.MaxValue);
    }

    public int Next(string login, int maxValue)
    {
        if (!users.ContainsKey(login))
        {
            throw new ArgumentException(
                $"User {login}: login is not registered");
        }
        return Next(login, 0, maxValue);
    }

    public int Next(string login, int minValue, int maxValue)
    {
        if (!users.ContainsKey(login))
        {
            throw new ArgumentException(
                $"User {login}: login is not registered");
        }
        if (users[login] < 20)
        {
            if (maxValue - minValue > 1000)
            {
                throw new ArgumentOutOfRangeException(
                    $"User {login}: random bounds out of range");
            }
        }
        int result = rnd.Next(minValue, maxValue);
        log.WriteLine($"User {login}: generate number {result}");
        return result;
    }

}
