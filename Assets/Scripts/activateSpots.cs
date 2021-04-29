using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateSpots : MonoBehaviour
{
    public hallwayDoor door;
    public GameObject spotlight;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            spotlight.SetActive(true);
            door.behindDoor = true;
        }
    }
}
