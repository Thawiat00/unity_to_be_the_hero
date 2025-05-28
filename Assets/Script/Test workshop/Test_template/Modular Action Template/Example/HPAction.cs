using UnityEngine;


[CreateAssetMenu(menuName = "MyActions/HPAction")]
public class HPAction : ScriptableObject, IAction<CharacterContextSO>
{

    public int Max_hp = 10; //assign inspector

    public int temp_hp;

    public string Id => name;

    public void Setup(CharacterContextSO content)
    {
        content.TempHP = 0 ;
       // Max_hp = content.HP;
    }


    public void Execute(CharacterContextSO context)
    {
        //   throw new System.NotImplementedException();
        context.TempHP = context.HP;  // Save temp
        context.HP = Max_hp;
        Debug.Log($"{context.Name} set max_hp { Max_hp} (current max HP: {context.HP})");

    }

   

    public void Stop(CharacterContextSO context)
    {
        // throw new System.NotImplementedException();
        Debug.Log("stop set_this_max_hp , turn to temp hp");
        context.HP = context.TempHP;
        Debug.Log($"{context.Name} set max_hp {Max_hp} (current max HP: {context.HP})");
    }

    public void Undo(CharacterContextSO context)
    {
        Debug.Log("undo doing set_max_hp");

        Debug.Log("undo set_this_max_hp , turn to temp hp");
        context.HP = context.TempHP;
        Debug.Log($"{context.Name} set max_hp {Max_hp} (current max HP: {context.HP})");

        //  throw new System.NotImplementedException();
    }
}
