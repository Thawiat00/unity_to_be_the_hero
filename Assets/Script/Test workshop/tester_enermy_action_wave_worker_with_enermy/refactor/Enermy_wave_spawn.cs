using UnityEngine;


public enum state_process_enermy_process
{
  enermy_remember_target,
  enermy_go_to_target,
  enermy_get_closer_target,
  enermy_stop_near_target,

}



public class Enermy_wave_spawn : MonoBehaviour
{
    public state_process_spawn_wave_enermy _state_Process_Spawn_Wave_Enermy;

    public state_process_enermy_process _state_process_enermy_process;

    public int order_enermy = 0;

    public Transform _target;

    private int waveLevel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _state_process_enermy_process = state_process_enermy_process.enermy_remember_target;
    }

    // Update is called once per frame
    void Update()
    {
        if (_state_process_enermy_process == state_process_enermy_process.enermy_go_to_target)
        {
            //  go_to_enermy
            go_to_enermy(_target);
        }
        else
        {
            Debug.Log("out of command");
        }
    }

   

    public void Initialize(int order )
    {


        order_enermy = order;
        Debug.Log("order_enermy : " + order_enermy);

       // go_to_enermy(_target_transform);

        //   waveLevel = level;
        //  Debug.Log("Wave level set to: " + waveLevel);
    }

    public void set_target_to_enermy_have_remember(Transform set_target)
    {
        _target = set_target;

        _state_process_enermy_process = state_process_enermy_process.enermy_go_to_target;

    }

  
    public void go_to_enermy(Transform target_Vector3_MoveTowards)
    {
        if(_target == null)
        {
            Debug.Log("not have target , no working");
        }
        else
        {

       
        int speed_Vector3_MoveTowards = 1;
        // Move our position a step closer to the target.
        var step = speed_Vector3_MoveTowards * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target_Vector3_MoveTowards.position, step);




        }



    }




}
