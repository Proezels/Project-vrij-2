using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public GameObject openedDoor;
    public GameObject closedDoor;

    void Start()
    {
        if (openedDoor != null)
        {
            openedDoor.SetActive(true);   
        }
        closedDoor.SetActive(false);    
    }
}
