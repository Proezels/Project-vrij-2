using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeLights : MonoBehaviour
{
    public Material shiny;
    private bool atTree = false;
    public GameObject spot;

    void Start()
    {
        shiny.DisableKeyword("_EMISSION");
    }

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
            spot.SetActive(true);
        }
    }
}
