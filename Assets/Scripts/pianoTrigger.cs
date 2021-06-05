using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianoTrigger : MonoBehaviour
{
    public GameObject startLight;
    public GameObject fullLight;
    public bool inFront = false;
    public AudioSource music;

    public bool humming = false;
    public bool mute = true;
    public AudioSource hum;
    bool cutscene = false;
    private float vol = 0f;
    public float increase = 0.005f;

    public GameObject cutsceneCam;
    public GameObject player;
    public GameObject fam;

    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
    }

//check if player infront of piano
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            inFront = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.name == "Player")
        {
            inFront = false;
        }
    }

//activate "cuscene", music camera etc.
    void OnMouseDown ()
    {
        if (inFront)
        {
            music.enabled = !music.enabled;
            startLight.SetActive(false);
            fullLight.SetActive(true);
            cutscene = true;
            
            player.SetActive(false);
            cutsceneCam.SetActive(true);
            fam.SetActive(true);
        }
    }

//let's you hum when spacebar is pressed
    void Update()
    {
        if (cutscene)
        {
            if (Input.GetKey("space") && mute)
            {
                humming = true;
                vol = vol + increase;
                audioMute();
                if (hum.volume >= 1f)
                {
                    vol = 1f;
                    mute = false;
                }
            }
            else if (humming)
            {
                mute = true;
                vol = vol - increase; 
                audioMute();
                if (vol <= 0f)
                {
                    vol = 0f;
                    humming = false;
                }
               
            }

            
        }
    }

    void audioMute()
    {
        if (humming)
        {
            hum.volume = vol;
        }
        else if (mute)
        {
            hum.volume = vol;
        }
    }
}
