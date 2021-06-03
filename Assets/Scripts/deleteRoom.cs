using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteRoom : MonoBehaviour
{
    public GameObject room;
    public GameObject door;
    public GameObject wall;

    public bool outside = false;
    private AudioSource audio;
    public AudioClip[] rainClips;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = rainClips[1];
        audio.PlayOneShot(audio.clip);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            Destroy(room);
            Destroy(door);
            wall.SetActive(true);
        }
    }

    void Update()
    {
        if (outside)
        {
            audio.clip = rainClips[0];
            audio.PlayOneShot(audio.clip);
            outside = false;
        }
    }
}
