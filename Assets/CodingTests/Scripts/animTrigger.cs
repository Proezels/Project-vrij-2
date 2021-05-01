using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTrigger : MonoBehaviour
{
   Animation anim;
   public bool triggered = false;
   public GameObject portal;
   public portal portalScript;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();     
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            anim.Play();
            triggered = false;
        }

        if (portalScript.exitRoom)
        {
            Destroy(gameObject);
            portalScript.exitRoom = false;
        }
    }

    void animDone()
    {
        portal.SetActive(true);
    }
}
