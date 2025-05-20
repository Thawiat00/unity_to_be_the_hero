using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// In this example we show how to invoke a coroutine and execute
// the function in parallel.  Start does not need IEnumerator.

//ref another example corotine
//  https://docs.unity3d.com/6000.0/Documentation/ScriptReference/MonoBehaviour.StartCoroutine.html



public class template_2_corotine_mono : MonoBehaviour
{

    // In this example we show how to invoke a coroutine and
    // continue executing the function in parallel.

    private IEnumerator coroutine;

    [SerializeField]
    private int max_spawn;

    void Start()
    {
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        coroutine = WaitAndPrint(2.0f);
        StartCoroutine(coroutine);

        print("Before WaitAndPrint Finishes " + Time.time);
    }

    // every 2 seconds perform the print()
    private IEnumerator WaitAndPrint(float waitTime)
    {
        int current_spawn = 0;

        while (current_spawn != max_spawn )
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);
        

            current_spawn = current_spawn + 1;
            print("current_sapwn: " + current_spawn);
        }
    }

}
