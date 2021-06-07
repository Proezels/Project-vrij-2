using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeLights : MonoBehaviour
{
    public Material shiny;
    public bool lights = false;
    private bool atTree = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            atTree = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.name == "Player")
        {
            atTree = false;
        }
    }

    void OnMouseDown()
    {
        if (atTree)
        {
            shiny.EnableKeyword("_EMISSION");
            lights = true;
        }
    }
}
