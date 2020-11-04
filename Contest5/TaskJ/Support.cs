using System;
using System.Collections.Generic;

public class Support
{
    private readonly List<Task> tasks = new List<Task>();
    private static int nextTaskId = 1;

    public IEnumerable<Task> Tasks => tasks;

    public int OpenTask(string text)
    {
        Task task = new Task(nextTaskId, text);
        tasks.Add(task);
        return nextTaskId++;
    }

    public void CloseTask(int id, string answer)
    {
        tasks[id - 1].Answer = answer;
        tasks[id - 1].IsResolved = true;
    }

    public List<Task> GetAllUnresolvedTasks()
    {
        List<Task> unresolvedTasks = new List<Task>();
        foreach (var task in tasks)
        {
            if (!task.IsResolved)
            {
                unresolvedTasks.Add(task);
            }
        }
        return unresolvedTasks;
    }

    public void CloseAllUnresolvedTasksWithDefaultAnswer(string answer)
    {
        foreach (var task in tasks)
        {
            if (!task.IsResolved)
            {
                task.Answer = answer;
                task.IsResolved = true;
            }
        }
    }

    public string GetTaskInfo(int id)
    {
        return tasks[id - 1].ToString();
    }
}