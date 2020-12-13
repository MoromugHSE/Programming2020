using System;
using System.Collections.Generic;

public partial class TestSystem
{
    List<User> users = new List<User>();

    public void Add(string username)
    {
        User user = new User(username);
        if (!users.Contains(user))
        {
            users.Add(user);
        }
        else
        {
            user = users.Find(x => x.Equals(user));
            foreach (Message handler in Notifications.GetInvocationList())
            {
                if (handler == user.message)
                {
                    throw new ArgumentException("User already exists");
                }
            }
        }
        Notifications += user.message;
    }

    public void Remove(string username)
    {
        User user = new User(username);
        if (!users.Contains(user))
        {
            throw new ArgumentException("User does not exist");
        }   
        user = users.Find(x => x.Username == username);
        foreach (Message handler in Notifications.GetInvocationList())
        {
            if (handler == user.message)
            {
                Notifications -= handler;
                return;
            }
        }
        throw new ArgumentException("User does not exist");
    }

}