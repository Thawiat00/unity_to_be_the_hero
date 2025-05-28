using UnityEngine;

[CreateAssetMenu(menuName = "MyActions/HealAction")]
public class HealAction : ScriptableObject, IAction<CharacterContextSO>
{
    public int healAmount = 10;

    public string Id => name;


    public void Setup(CharacterContextSO content)
    {
        throw new System.NotImplementedException();
    }


    public void Execute(CharacterContextSO context)
    {
      //  context.TempHP = context.HP;  // Save temp
        context.HP += healAmount;
        Debug.Log($"{context.Name} healed for {healAmount} (HP: {context.HP})");
    }

   
    public void Stop(CharacterContextSO context)
    {
       
        Debug.Log($"{context.Name} Stop healed for {healAmount} (HP: {context.HP})");
    }

    public void Undo(CharacterContextSO context)
    {
       // context.HP = context.TempHP;   // use temp
        Debug.Log($"Undo heal: {healAmount} (HP: {context.HP})");
    }
}