using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryTrigger : MonoBehaviour
{
    public GameObject roomObjects;
    public bool memoryActive = false;
    Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }


    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            memoryActive = true;
        }
    }

    void OnMouseDown()
    {
        if (memoryActive)
        {
            anim.Play("fadeOutAnim");

        }
    }

    void animEnd()
    {
        roomObjects.SetActive(true);
    }
}
