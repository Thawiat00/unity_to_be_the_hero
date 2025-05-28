using UnityEngine;



#region Interfaces

public interface IAction<T>
{
    string Id { get; }

    void Setup(T content);
    void Execute(T context);
    void Undo(T context);

    void Stop(T context);
}

public interface IActionCondition<T>
{
    bool IsSatisfied(T context);
}

#endregion
