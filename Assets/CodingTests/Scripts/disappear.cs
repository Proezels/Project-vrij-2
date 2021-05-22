using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public GameObject obj;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            obj.SetActive(false);
        }
    }
}
