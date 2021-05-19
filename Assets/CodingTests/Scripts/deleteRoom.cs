using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteRoom : MonoBehaviour
{
    public GameObject room;
    public GameObject door;
    public GameObject wall;

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            Destroy(room);
            Destroy(door);
            wall.SetActive(true);
        }
    }
}
