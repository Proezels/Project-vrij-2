using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianoTrigger : MonoBehaviour
{
    public GameObject startLight;
    public GameObject fullLight;
    public bool inFront = false;

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            inFront = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.name == "Player")
        {
            inFront = false;
        }
    }

    void OnMouseDown ()
    {
        if (inFront)
        {
            startLight.SetActive(false);
            fullLight.SetActive(true);
        }
    }
}
