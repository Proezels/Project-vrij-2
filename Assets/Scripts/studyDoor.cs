using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyDoor : MonoBehaviour
{
    public bool atDoor = false;
    public playerMovement p1;
    Animation anim;
    BoxCollider coll;
    public GameObject rain;
    public deleteRoom delete;
    public AudioClip[] audioArray;
    AudioSource audio;
    AudioSource sound;
    public AudioClip[] doorSounds;


    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        coll = gameObject.GetComponent<BoxCollider>();
        audio = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.name == "Player")
        {
                atDoor = true;
        }
    }

    void OnTriggerExit (Collider Other)
    {
        if (Other.name == "Player")
        {
            atDoor = false;
        }
    }

    void OnMouseDown ()
    {
        if (p1.maskOn)
        {  
            rain.SetActive(true);
            delete.outside = true;
            anim.Play();
            coll.enabled = !coll.enabled;
            sound.clip = doorSounds[1];
            sound.Play();
        }
        else 
        {        
            audio.clip = audioArray[Random.Range(0, audioArray.Length)];
            audio.PlayOneShot(audio.clip);
            sound.clip = doorSounds[1];
            sound.Play();
        }
    }
}
