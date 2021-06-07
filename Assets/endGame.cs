using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    private bool endable = false;

    void Update()
    {
        if (endable)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("End game");
            }
        }
    }

    void ending()
    {
        endable = true;
    }
}
