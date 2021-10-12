using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject collisionParticle;
    public GameObject triggerParticle;

    //These get executed when something enters the trigger, or when this object enters a trigger.
    private void OnTriggerEnter(Collider other)
    {
        if (triggerParticle != null)
        {
            //The triggerParticle will be spawned at the location of this object
            //with the same rotation as this object
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation);
        }
    }

    //gets executed when something collides with this object
    private void OnCollisionEnter(Collision collision)
    {
        if (collisionParticle != null)
        {
            Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);
        }
    }
}
