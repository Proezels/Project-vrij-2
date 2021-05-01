using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public GameObject otherPortal;
    public GameObject player;
    CharacterController cc; 
    public bool exitRoom;

    void Start()
    {
        cc = player.GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (otherPortal != null)
            {
                cc.enabled = false;
                other.transform.position = otherPortal.transform.position;
                cc.enabled = true;
                exitRoom = true;
            }
        }
    }

   
    



}
