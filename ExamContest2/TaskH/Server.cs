using System;
using System.Collections.Generic;

public class Server
{
    private string name;
    List<string> logs = new List<string>();

    private static Server server;

    public Server()
    {
    }

    private Server(string name)
    {
        server = this;
        this.name = name;
    }

    public static Server Connect(string name)
    {
        if (server == null)
        {
            server = new Server(name);
        }
        return server;
    }

    public void Send(string message)
    {
        if (name == null)
        {
            throw new ArgumentException("No connected server");
        }
        logs.Add($"Sending data {message} to server {name}");
    }

    public void Receive(string message)
    {
        if (name == null)
        {
            throw new ArgumentException("No connected server");
        }
        logs.Add($"Receiving data {message} from server {name}");
    }

    public void Output()
    {
        if (name == null)
        {
            throw new ArgumentException("No connected server");
        }
        foreach (var log in logs)
        {
            Console.WriteLine(log);
        }
        logs.Clear();
    }
}