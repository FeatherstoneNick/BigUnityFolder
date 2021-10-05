using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody reggiebody;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //Vector3.up = (0, 1, 0) this is the vector that we will use. 
            Vector3 forceVector = Vector3.up * jumpForce;
            reggiebody.AddForce(forceVector);

            print("Down");
        }
        else if (Input.GetButtonDown("Jump"))
        {
            print("Hold");
        }
        else if (Input.GetButtonDown("Jump"))
        {
            print("Up");
        }
    }

}