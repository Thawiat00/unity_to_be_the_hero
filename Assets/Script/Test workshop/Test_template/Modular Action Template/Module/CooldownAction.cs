using System;
using UnityEngine;

#region Cooldown / Repeat Limit Wrapper

[CreateAssetMenu(menuName = "MyActions/CooldownWrapper")]
public class CooldownAction<T> : ScriptableAction<T>
{
    [SerializeReference] public ScriptableAction<T> wrappedAction;
    public float cooldownSeconds = 5f;
    public int repeatLimit = -1;

    private DateTime lastUsedTime = DateTime.MinValue;
    private int timesUsed = 0;

    public override void Execute(T context)
    {
        var now = DateTime.UtcNow;

        if ((now - lastUsedTime).TotalSeconds < cooldownSeconds)
        {
            Debug.LogWarning($"Action {Id} on cooldown.");
            return;
        }

        if (repeatLimit > 0 && timesUsed >= repeatLimit)
        {
            Debug.LogWarning($"Action {Id} exceeded repeat limit.");
            return;
        }

        wrappedAction?.Execute(context);
        lastUsedTime = now;
        timesUsed++;
    }

    public override void Undo(T context)
    {
        wrappedAction?.Undo(context);
    }
}

#endregion