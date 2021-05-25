using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyDoor : MonoBehaviour
{
    public bool atDoor = false;
    public playerMovement p1;
    Animation anim;
    BoxCollider coll;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        coll = gameObject.GetComponent<BoxCollider>();
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
            anim.Play();
            coll.enabled = !coll.enabled;
        }
        else 
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
