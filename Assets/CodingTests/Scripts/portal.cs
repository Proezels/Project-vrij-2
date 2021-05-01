using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public GameObject otherPortal;
    public GameObject player;
    CharacterController cc; 
    public bool exitRoom;
    public int loops = 0;
    public GameObject easteregg;

    void Start()
    {
        cc = player.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (loops == 3)
        {
            easteregg.SetActive(true);
        }
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
                loops = loops + 1;
            }
        }
    }


   
    



}
