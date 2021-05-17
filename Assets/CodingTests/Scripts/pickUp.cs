using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public playerMovement p1;

    void OnMouseDown ()
    {
        p1.maskOn = true;
        Destroy(gameObject);
    }
}
