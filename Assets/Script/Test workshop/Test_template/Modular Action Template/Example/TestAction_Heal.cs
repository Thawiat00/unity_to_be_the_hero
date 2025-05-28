using Unity.Collections;
using UnityEngine;

#region Part 1: Basic Usage (Easy)

// ?? ?????? HealAction ??????????? MonoBehaviour
public class TestAction_Heal : MonoBehaviour
{
    public HealAction healAction;
    public HPAction hp_Action;
    public CharacterContextSO character;


    [Header("Inspector HP Character")]
   [SerializeField, ReadOnly] private int _see_max_hp;

    void Start()
    {
        

        //   CharacterContext ctx = new CharacterContext { Name = "Hero", HP = 20 };


        //   hp_Action.temp_hp = ctx.HP;
        // ctx.HP


        character.Setup(character);
        character.Execute(character);
        //    character.Stop(character);
        //    character.Undo(character);


        //    healAction.Execute(character); // Output: Hero healed for X
        //     healAction.Stop(character);  //Output: Hero stop healed for X
        //     healAction.Undo(character);    // Output: Undo heal Optional

        hp_Action.Setup(character);    //  Output: setup Hero set_hp for X
        hp_Action.Execute(character);  //  Output: excute Hero set_hp for X
   //     hp_Action.Stop(character);    // Output: Hero stop set_hp for X
     //   hp_Action.Undo(character);     // Output: Hero  Undo set_hp Optional


        _see_max_hp = character.HP;
    }
}

#endregion
