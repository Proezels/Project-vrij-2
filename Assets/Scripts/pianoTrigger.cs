using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianoTrigger : MonoBehaviour
{
    public bool inFront = false;
    public treeLights tree;
    AudioSource music;

    public bool humming = false;
    public bool mute = true;
    public AudioSource hum;
    bool cutscene = false;
    private float vol = 0f;
    public float increase = 0.005f;

    public GameObject cutsceneCam;
    public GameObject player;
    public GameObject fam;
    public GameObject pianoPlayer;
    private float humTimer = 0f;
    public float introSec = 19f;
    public GameObject spaceText;

    public GameObject credits;
    private float creditTimer;

    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
    }

//check if player infront of piano
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player" && tree.lights)
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
        if (inFront && cutscene == false)
        {
            music.enabled = !music.enabled;
            hum.Play();
            cutscene = true;
            
            player.SetActive(false);
            pianoPlayer.SetActive(true);
            cutsceneCam.SetActive(true);
            fam.SetActive(true);
            
        }
    }

//let's you hum when spacebar is pressed
    void Update()
    {
        if (cutscene)
        {
            humTimer += Time.deltaTime;
            if (humTimer >= introSec)
            {
                humTimer = 0f;
                spaceText.SetActive(true);
            }

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
            creditTimer = creditTimer + 1;
            if (creditTimer >= 1000)
            {
                credits.SetActive(true);
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
