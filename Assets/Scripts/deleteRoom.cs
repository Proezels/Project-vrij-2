using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteRoom : MonoBehaviour
{
    public GameObject room;
    public GameObject door;
    public GameObject wall;

    public bool outside = false;
    private AudioSource sound;
    public AudioClip[] rainClips;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.clip = rainClips[1];
        sound.PlayOneShot(sound.clip);
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
            sound.clip = rainClips[0];
            sound.PlayOneShot(sound.clip);
            outside = false;
        }
    }
}
