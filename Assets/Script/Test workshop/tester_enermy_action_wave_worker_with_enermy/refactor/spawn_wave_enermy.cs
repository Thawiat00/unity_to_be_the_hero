using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public enum state_process_spawn_wave_enermy
{
  set_list_Point_spawn_enermy,
  start_spawn_enermy,
  set_temp_clone_enermy_order,
  command_enermy_go_target_direction,
  detect_enermy_go_out_area_spawn,
  delay_spawn_enermy,
  continue_spawn_new_point_enermy,
  pause_spawn_enermy,
  stop_spawn_enermy,

}



public class spawn_wave_enermy : MonoBehaviour
{

    [Header("Help set_list_Point_spawn_enermy")]
    public int current_list_point ;
    public List<Transform> Point_spawn;

    [Header("Help state_process_spawn_wave_enermy ")]
    public state_process_spawn_wave_enermy state_Process_wave_enermy;

   //[Head]

 
    [Header("Help wave_enermy_Point_spawn_enermy")]
    public Transform Point_A_spawn;
    public Transform Point_B_spawn;

    [Header("Help wave_enermy_Point_Direction_enermy")]
    public Transform Point_Direction_enermy;

    [Header("Help Prefabs enermy")]
    public GameObject prefabs_enermy;

    [Header("Help temp clone enermy")]
    public GameObject temp_clone_enermy;

    [Header("Help prepare_for_point_spawn_before_detect")]
    public Transform temp_point_spawn;


    [Header("Help temp clone enermy and distant point_spawn_enermy")]
    public float closeDistance;
   // public bool can_spawn_another_point_spawn;

    [Header("Help  delay_spawn_enermy")]
    public int max_spawn;
    private IEnumerator coroutine;
   
    // In this example we show how to invoke a coroutine and
    // continue executing the function in parallel.




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        manage_start_setup_state_spawn_enermy();
    }

    public void manage_start_setup_state_spawn_enermy()
    {
        if (state_Process_wave_enermy == state_process_spawn_wave_enermy.set_list_Point_spawn_enermy)
        {

            setup_get_point_spawn_enermy();
        }

       else if (state_Process_wave_enermy == state_process_spawn_wave_enermy.start_spawn_enermy)
        {
           
        }
        else if (state_Process_wave_enermy == state_process_spawn_wave_enermy.set_temp_clone_enermy_order)
        {
            
        }

        else if(state_Process_wave_enermy == state_process_spawn_wave_enermy.command_enermy_go_target_direction)
        {

        }

        else if(state_Process_wave_enermy == state_process_spawn_wave_enermy.detect_enermy_go_out_area_spawn)
        {

        }
        else if(state_Process_wave_enermy == state_process_spawn_wave_enermy.delay_spawn_enermy)
        {
            
        }
        else if(state_Process_wave_enermy == state_process_spawn_wave_enermy.continue_spawn_new_point_enermy)
        {

        }
        else if(state_Process_wave_enermy == state_process_spawn_wave_enermy.pause_spawn_enermy)
        {

        }
        else if(state_Process_wave_enermy == state_process_spawn_wave_enermy.stop_spawn_enermy)
        {

        }
        else
        {
            Debug.Log("out of state");
        }

    }


    public void manage_update_state_spawn_enermy()
    {
        if (state_Process_wave_enermy == state_process_spawn_wave_enermy.set_list_Point_spawn_enermy)
        {
            
            get_point_spawn_enermy(current_list_point);

            // set_point_spawn_enermy_to_prepare_detect_enermy();

            state_Process_wave_enermy = state_process_spawn_wave_enermy.start_spawn_enermy;

        }

       else if (state_Process_wave_enermy == state_process_spawn_wave_enermy.start_spawn_enermy)
        {
          //  start_spawn_enermy();

            start_spawn_enermy(current_list_point);

           

            state_Process_wave_enermy = state_process_spawn_wave_enermy.set_temp_clone_enermy_order;

        }
        else if(state_Process_wave_enermy == state_process_spawn_wave_enermy.set_temp_clone_enermy_order)
        {
            temp_clone_order();




            state_Process_wave_enermy = state_process_spawn_wave_enermy.command_enermy_go_target_direction;
        }

        else if(state_Process_wave_enermy == state_process_spawn_wave_enermy.command_enermy_go_target_direction)
        {
            command_enermy_go_target_direction();



            state_Process_wave_enermy = state_process_spawn_wave_enermy.detect_enermy_go_out_area_spawn;
        }

        else if (state_Process_wave_enermy == state_process_spawn_wave_enermy.detect_enermy_go_out_area_spawn)
        {

         

            detect_enermy_go_out_area_spawn(Point_spawn,current_list_point);


        }
        else if (state_Process_wave_enermy == state_process_spawn_wave_enermy.delay_spawn_enermy)
        {

            delay();

            state_Process_wave_enermy = state_process_spawn_wave_enermy.continue_spawn_new_point_enermy;
        }



        else if (state_Process_wave_enermy == state_process_spawn_wave_enermy.continue_spawn_new_point_enermy)
        {

            continue_spawn_enermy();

        }
        else if (state_Process_wave_enermy == state_process_spawn_wave_enermy.pause_spawn_enermy)
        {

            pause_spawn_enermy();

            state_Process_wave_enermy = state_process_spawn_wave_enermy.stop_spawn_enermy;
        }
        else if (state_Process_wave_enermy == state_process_spawn_wave_enermy.stop_spawn_enermy)
        {

            stop_spawn_enermy();

        }
        else
        {

            Debug.Log("out of state");


        }

    }

    private void set_point_spawn_enermy_to_prepare_detect_enermy()
    {
        throw new NotImplementedException();
    }

    public void setup_get_point_spawn_enermy()
    {

        current_list_point = 0;
    }

    private void get_point_spawn_enermy(int current_point)
    {

        // int current_point = 0;
        if (current_list_point <= Point_spawn.Count)
        {
            Debug.Log(" Point_spawn[current_point].name:" + Point_spawn[current_point].name);
            // Point_spawn[current_point].name;

            //  throw new NotImplementedException();
            // temp_point_spawn = p


        }



    }

    public void setup_spawn_enermy_()
    {



    }




    public void spawn_enermy()
    {


    }


    public void setup_command_enermy_go_target_direction()
    {

    }

    public void command_enermy_go_target_direction()
    {

        Debug.Log("command_enermy_go_target_direction_");

        temp_clone_enermy.GetComponent<Enermy_wave_spawn>().set_target_to_enermy_have_remember(Point_Direction_enermy);

    }

    public void start_spawn_enermy(int current_point_spawn)
    {

        //Instantiate(prefabs_enermy, new Vector3( Point_A_spawn.position.x, 0, Point_A_spawn.position.z), Quaternion.identity);
        temp_clone_enermy = Instantiate(prefabs_enermy, new Vector3(Point_spawn[current_point_spawn].position.x, 0, Point_spawn[current_point_spawn].position.z), Quaternion.identity);
        Debug.Log("spawn enermy :" + Point_spawn[current_point_spawn].name);
    }

    public void temp_clone_order()
    {

        temp_clone_enermy.GetComponent<Enermy_wave_spawn>().Initialize(2);
    }


    public void pause_spawn_enermy()
    {
        Debug.Log("pause_spawn_enermy");

    }


    public void continue_spawn_enermy()
    {
        // Debug.Log()

        int max_count = Point_spawn.Count-1; 

        if (current_list_point != max_count)
        {
            Debug.Log("current_list_point" + +current_list_point  + " not equal Point_spawn.Count ");
            Debug.Log(" start spawn another point enermy");

            //current_list_point += current_list_point;
            current_list_point = current_list_point + 1;

            state_Process_wave_enermy = state_process_spawn_wave_enermy.set_list_Point_spawn_enermy;
        }
        else if(current_list_point == max_count)
        {
            Debug.Log("current_list_point" + +current_list_point + " is == Point_spawn.Count ");
            Debug.Log("pause spawn another point enermy");


            state_Process_wave_enermy = state_process_spawn_wave_enermy.pause_spawn_enermy;
        }
        else
        {


            Debug.Log("out of state continue_spawn_enermy() ");


        }

    }



    public void stop_spawn_enermy()
    {

        Debug.Log("_stop_spawn_enermy_");
    }


    public void delay()
    {

        Debug.Log("Delay 2 ms");
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        coroutine = WaitAndPrint(2.0f);
        StartCoroutine(coroutine);

      //  print("Before WaitAndPrint Finishes " + Time.time);
    }


    // every 2 seconds perform the print()
    private IEnumerator WaitAndPrint(float waitTime)
    {
        int current_spawn = 0;

        while (current_spawn != max_spawn)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);


            current_spawn = current_spawn + 1;
            print("current_sapwn: " + current_spawn);
        }
    }


    // public void detect_enermy_go_out_area_spawn(Transform point_spawn_detect)
    public void detect_enermy_go_out_area_spawn(List<Transform> list_point_spawn_detect ,int current_point )
    {

        
        
        Debug.Log("detect_enermy_go_out_area_spawn");



        //  Debug.Log("Point_A_spawn.transform.position:"+Point_A_spawn.transform.position);
        //  Debug.Log("temp_clone_enermy.transform.position:" + temp_clone_enermy.transform.position);


        //Vector3 offset = temp_clone_enermy.transform.position - transform.position;
        //  Vector3 offset = temp_clone_enermy.transform.position - point_spawn_detect.transform.position;
        Vector3 offset = temp_clone_enermy.transform.position - list_point_spawn_detect[current_point].transform.position;
        float sqrLen = offset.sqrMagnitude;

        // square the distance we compare with
        if (sqrLen < closeDistance * closeDistance)
        {
            print("The other transform is close to me!");
        }
        else
        {
            Debug.Log("it's too far");
            Debug.Log("can make delay");

            state_Process_wave_enermy = state_process_spawn_wave_enermy.delay_spawn_enermy; 

        }

        /*
        if (Point_A_spawn)
        {
            //Vector3 offset = temp_clone_enermy.transform.position - transform.position;
            Vector3 offset = temp_clone_enermy.transform.position - Point_A_spawn.transform.position;
            float sqrLen = offset.sqrMagnitude;

            // square the distance we compare with
            if (sqrLen < closeDistance * closeDistance)
            {
                print("The other transform is close to me!");
            }
        }
        else
        {
            Debug.Log("it's too far");
        }
        */



    }

    public void enermy_go_to_destination()
    {


    }
   

    public void destroy_enermy()
    {


    }

    public void enermy_idel()
    {

    }



    public void enermy_moving()
    {



    }


    public void enermy_stop_moving()
    {



    }

 



    // Update is called once per frame
    void Update()
    {
        manage_update_state_spawn_enermy();
        

    }


}
