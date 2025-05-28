using System.Collections.Generic;
using UnityEngine;

#region Priority Queue

public class PriorityAction<T>
{
    public IAction<T> Action;
    public int Priority;

    public PriorityAction(IAction<T> action, int priority)
    {
        Action = action;
        Priority = priority;
    }
}

public class PriorityActionQueue<T>
{
    private readonly List<PriorityAction<T>> _queue = new();

    public void Enqueue(IAction<T> action, int priority)
    {
        _queue.Add(new PriorityAction<T>(action, priority));
        _queue.Sort((a, b) => b.Priority.CompareTo(a.Priority)); // Descending
    }

    public void ExecuteAll(T context)
    {
        foreach (var item in _queue)
            item.Action.Execute(context);

        _queue.Clear();
    }
}

#endregion