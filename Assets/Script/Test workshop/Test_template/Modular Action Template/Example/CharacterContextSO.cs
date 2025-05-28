using UnityEngine;


[CreateAssetMenu(menuName = "Character/Context")]
public class CharacterContextSO : ScriptableObject, IAction<CharacterContextSO>
{
    public string Name;

    [SerializeField] private int hp = 20;
    public int HP
    {
        get => hp;
        set => hp = value;
    }

    // public int HP;
    public int default_hp;
    public int TempHP;
    public string TempName;

    public string Id => Name;

    public void Setup(CharacterContextSO content)
    {
        if(default_hp == 0)
        {
            default_hp = content.HP;
        }
        //set_temp_to 0;

        content.HP = default_hp;
        content.TempHP = content.HP;
        content.TempName = "";
      //  TempHP = 0;
      //  TempName = "";
    }


    public void Execute(CharacterContextSO context)
    {
        context.TempHP = context.HP;  // Save temp HP
        context.TempName = context.Name;  // Save temp Name
        context.HP = HP;
        Debug.Log($"character Name{context.Name} Set base hp (HP: {context.HP})");
    }

    public void Stop(CharacterContextSO context)
    {

        Debug.Log("no use base hp on CharacterContextSO ");
        Debug.Log("it's current hp" + context.HP);
        Debug.Log("it's current name" + context.Name);

    }

    public void Undo(CharacterContextSO context)
    {
        if(context.TempHP == 0 && context.TempName == "")
        {
            context.TempHP = context.HP;  // Save temp HP
            context.TempName = context.Name;  // Save temp Name

            Debug.Log("redo for temp name and temphp first time ");
            Debug.Log($"character Name{context.Name} Set base hp (HP: {context.HP})");
        }
        else
        {
            context.HP = context.TempHP;  // Save temp HP
            context.Name = context.TempName;  // Save temp Name

            Debug.Log("redo for temp name and temphp if excute already ");
            Debug.Log($"character Name{context.Name} Set base hp (HP: {context.HP})");
        }

   
    }

  
}
