using System;
using System.Collections.Generic;
using System.Text;

public class User
{
    string username;
    List<string> messages;
    public TestSystem.Message message;

    public User(string username)
    {
        this.username = username;
        messages = new List<string>();
        message = (text) => SendMessage(text);
    }

    public string Username
    {
        get => username;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"-{username}-");
        if (messages.Count > 0)
        {
            sb.AppendLine("Received notifications:");
            foreach (var mess in messages)
            {
                sb.AppendLine(mess);
            }
        }
        return sb.ToString();

    }

    public void SendMessage(string text)
    {
        Console.Write(this);
        messages.Add(text);
        Console.WriteLine($"New notification: {text}");
    }

    public override bool Equals(object obj)
    {
        return obj is User user ? username == user.username : false;
    }

}