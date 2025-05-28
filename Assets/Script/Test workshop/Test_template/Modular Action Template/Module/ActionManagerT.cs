using System.Collections.Generic;
using UnityEngine;

#region Action Manager (CRUD & Switchable)

// ?????? Add/Remove/Replace Actions ??? runtime
public class ActionManagerT<T>
{
    private readonly Dictionary<string, IAction<T>> _actions = new();

    public void AddAction(IAction<T> action)
    {
        if (!_actions.ContainsKey(action.Id))
            _actions.Add(action.Id, action);
    }

    public void RemoveAction(string id)
    {
        if (_actions.ContainsKey(id))
            _actions.Remove(id);
    }

    public void ReplaceAction(IAction<T> newAction)
    {
        _actions[newAction.Id] = newAction;
    }

    public void ExecuteAction(string id, T context)
    {
        if (_actions.TryGetValue(id, out var action))
        {
            action.Execute(context);
            ActionEventBus.RaiseActionExecuted(id);
        }
    }

    public void UndoAction(string id, T context)
    {
        if (_actions.TryGetValue(id, out var action))
        {
            action.Undo(context);
            ActionEventBus.RaiseActionUndone(id);
        }
    }

    public void ClearAll() => _actions.Clear();
    public bool HasAction(string id) => _actions.ContainsKey(id);
}

#endregion