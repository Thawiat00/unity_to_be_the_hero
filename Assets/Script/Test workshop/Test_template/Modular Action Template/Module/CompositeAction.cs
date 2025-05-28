using System.Collections.Generic;
using UnityEngine;

#region Composite Action

[CreateAssetMenu(menuName = "MyActions/Composite")]
public class CompositeAction<T> : ScriptableAction<T>
{
    [SerializeReference] public List<ScriptableAction<T>> actions = new();

    public override void Execute(T context)
    {
        foreach (var action in actions)
            action.Execute(context);
    }

    public override void Undo(T context)
    {
        for (int i = actions.Count - 1; i >= 0; i--)
            actions[i].Undo(context);
    }
}

#endregion