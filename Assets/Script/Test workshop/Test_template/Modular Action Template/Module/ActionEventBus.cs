using System;
using UnityEngine;



#region Event System (Safe Static)

// Safe Static Event Manager ?????? runtime swap ??? memory-safe
public static class ActionEventBus
{
    public static event Action<string> OnActionExecuted;
    public static event Action<string> OnActionUndone;

    public static void RaiseActionExecuted(string actionId)
        => OnActionExecuted?.Invoke(actionId);

    public static void RaiseActionUndone(string actionId)
        => OnActionUndone?.Invoke(actionId);
}

#endregion