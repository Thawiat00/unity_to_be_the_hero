using UnityEngine;
using System.Collections;


[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{


    public float speed = 3.0f;
    public float rotateSpeed = 1.0f;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }


}
