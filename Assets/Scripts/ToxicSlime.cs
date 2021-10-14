using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicSlime : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
             //spawn explosion effects
        Vector3 particleSPawnPoint = other.transform.position;
             //To spawn a particle you use Instantiate
        Instantiate(explosionEffect, particleSPawnPoint, Quaternion.identity); 
            //Quaternion means with no rotation


        //Destroy() is the base function for destroying components and objects in a scene
        //YOu need to specify that you are reffering to a game object.
        //Destroy(hs), for instance, will destroy the component, not the object.
        //Destroy(this.gameObject) will destroy the object where this component is.
        Destroy(other.gameObject);
    }
}
