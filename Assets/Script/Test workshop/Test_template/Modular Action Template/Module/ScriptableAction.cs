using UnityEngine;
using System;



#region ScriptableObject-Based Action

// Action ??? config ?????? asset (????????????????????)
public abstract class ScriptableAction<T> : ScriptableObject, IAction<T>
{
    [SerializeField] private string id = Guid.NewGuid().ToString();
    public string Id => id;

    public abstract void Execute(T context);

    public void Setup(T content)
    {
        throw new NotImplementedException();
    }

    public virtual void Stop(T context)
    {
    }

    public virtual void Undo(T context) { }
}

#endregion