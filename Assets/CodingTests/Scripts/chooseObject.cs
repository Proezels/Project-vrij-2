using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseObject : MonoBehaviour
{
    public GameObject lights;
    public bool inside = false;
    public GameObject scene;
    public GameObject door;
    public GameObject picture;
    

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            inside = true;
        }
    }

    void OnMouseDown()
    {
        if (inside)
        {
            scene.SetActive(true);
            door.SetActive(false);
            lights.SetActive(false);
            picture.SetActive(true);
            Destroy(gameObject);
            
        }
    }
}
