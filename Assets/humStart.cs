using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humStart : MonoBehaviour
{
    public AudioSource famHum;
    public GameObject original;

    void Start()
    {
        famHum.volume = 1f;
        original.SetActive(false);
    }
}
