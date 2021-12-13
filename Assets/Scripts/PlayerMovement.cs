using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed=1.0f;
    public float rotSpeed=1.0f;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        //Rotate
        transform.Rotate(0, joystick.Horizontal * rotSpeed, 0);

        //Move Forward and Backward
        Vector3 move = transform.TransformDirection(Vector3.forward);
        float newSpeed = speed * joystick.Vertical;
        controller.SimpleMove(move * newSpeed);
    }
}
