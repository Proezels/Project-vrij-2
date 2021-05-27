using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{   
    public GameObject white;

    void OnTriggerEnter (Collider other)
    {
        if (white != null)
        {
            white.SetActive(true);
        }
    }

    void loadScene()
    {
        SceneManager.LoadScene("partyScene");
    }
}
