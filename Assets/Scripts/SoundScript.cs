using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    //The sound that will play when an object enters a trigger
    public AudioClip triggerSound;
    //The ausdio source that will play that sound
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        // Tell the source to play sound triggersound 
        source.PlayOneShot(triggerSound);
    }
}
