using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateSpots : MonoBehaviour
{
    public hallwayDoor door;
    public GameObject spotlight;
    public bool spotActive = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (!spotActive)
            {
                spotlight.SetActive(true);
                spotActive = true;
                door.behindDoor = true;
            }
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (spotActive)
        {
            spotActive = false;
        }
    }
}
