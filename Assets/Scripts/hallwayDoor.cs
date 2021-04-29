using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hallwayDoor : MonoBehaviour
{
    Animation anim;
    public bool atDoor = false;
    public bool behindDoor = false;

void Start()
{
    anim = gameObject.GetComponent<Animation>();
}

void Update()
{
    if (behindDoor)
    {
        anim.Play("doorCloseTest");
        behindDoor = false;
    }
}

 void OnTriggerEnter (Collider other)
 {
     if (other.name == "Player")
     {
        atDoor = true;
     }
 }

 void OnTriggerExit (Collider other)
 {
     if (other.name == "Player")
     {
        atDoor = false;
     }
 }

 void OnMouseDown()
 {
     if (atDoor)
     {
        anim.Play("doorOpenTest");
     }
 }

    

}
