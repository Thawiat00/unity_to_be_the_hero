using UnityEngine;


#region Conditional Action

[CreateAssetMenu(menuName = "MyActions/Conditional_modify")]
public class ConditionalAction_modify<T> : ScriptableAction<T>
{

    [SerializeReference] public ScriptableAction<T> action;
    [SerializeReference] public ScriptableObject conditionAsset;

    public override void Execute(T context)
    {
        if (conditionAsset is IActionCondition<T> condition && condition.IsSatisfied(context))
            action?.Execute(context);
    }

    public override void Undo(T context)
    {
        if (conditionAsset is IActionCondition<T> condition && condition.IsSatisfied(context))
            action?.Undo(context);
    }

}


#endregion