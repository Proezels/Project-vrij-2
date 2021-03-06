using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hallwayDoor : MonoBehaviour
{
    Animation anim;
    public bool atDoor = false;
    public bool behindDoor = false;
    public GameObject portal;
    public bool doorOpen = false;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    void Update()
    {
        if (behindDoor)
        {  
            if (doorOpen)
            {
                anim.Play("doorCloseTest");
                behindDoor = false;
                doorOpen = false;
            }
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            atDoor = true;
            portal.SetActive(false);
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.name == "Player")
        {
            atDoor = false;
        }
    }

    void OnMouseDown()
    {
        if (atDoor)
        {
            anim.Play("doorOpenTest");
            doorOpen = true;
        }
    }

}
