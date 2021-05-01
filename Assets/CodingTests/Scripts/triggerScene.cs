using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScene : MonoBehaviour
{
    public GameObject door;
    public animTrigger anim;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            door.SetActive(true);
            anim.triggered = true;
        }
    }
}
