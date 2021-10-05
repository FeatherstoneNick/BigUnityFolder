using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public CharacterController controller;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //yeet
        Vector3 movement = new Vector3(x, 0, y);
        movement = movement.normalized * speed * Time.deltaTime;
        //yeet
        Vector3 newPosition = transform.position;
        newPosition = newPosition + movement;
        //yeet

        //transform.position = newPosition;
        controller.Move(movement);
    }
}
