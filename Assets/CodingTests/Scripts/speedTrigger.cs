using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedTrigger : MonoBehaviour
{   
    public playerMovement p1;
    private float newSpeed = 2f;
    public bool slower = false;

    
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            if (!slower)
            {
                p1.speed = p1.speed - newSpeed;    
                slower = true;
            }
        
        }
    }
}
