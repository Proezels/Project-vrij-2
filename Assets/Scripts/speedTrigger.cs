using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedTrigger : MonoBehaviour
{   
    public playerMovement p1;
    public float newSpeed = 1f;
    private bool slower = false;

    
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            if (!slower)
            {
                p1.speed = p1.speed - newSpeed;    
                slower = true;
                gameObject.GetComponent<AudioSource>().Play();
            }
        
        }
    }
}