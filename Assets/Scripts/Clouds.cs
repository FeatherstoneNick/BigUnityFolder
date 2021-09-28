using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed = 2f;

    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = this.transform.position;

        temp.x = temp.x + speed * Time.deltaTime;

        this.transform.position = temp;
    }
}