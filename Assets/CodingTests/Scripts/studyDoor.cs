using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyDoor : MonoBehaviour
{
    public bool atDoor = false;
    public playerMovement p1;

    void OnTriggerEnter(Collider Other)
    {
        if (Other.name == "Player")
        {
            if (p1.maskOn)
            {  
                atDoor = true;
            }
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
        if (atDoor)
        {
            gameObject.SetActive(false);
        }
    }
}