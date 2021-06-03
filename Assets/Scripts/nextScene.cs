using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{   
    public GameObject white;
    public bool test = false;

    void Update()
    {
        if (test)
        {
            audioFade();
            test = false;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (white != null)
        {
            audioFade();
            white.SetActive(true);
        }
    }

    void loadScene()
    {
        SceneManager.LoadScene("partyScene");
    }

    void audioFade()
    {
        AudioSource whiteNoise = GetComponent<AudioSource>();
        whiteNoise.volume = whiteNoise.volume - 0.2f;

        if (whiteNoise.volume <= 0f)
        {
            whiteNoise.volume = 0f;
        }
    }
}
