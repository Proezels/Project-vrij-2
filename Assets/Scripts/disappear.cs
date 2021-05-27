using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public float fadeIn = 0f; 
    public Material picnic;
    public Material park;
    public bool fading = false;
    float startTime;
    public GameObject fireflies;
    [SerializeField] [Range (0f, 1f)] float lerpTime;
    [SerializeField] Color myColor;

    void Start()
    {
    //sets starting color to dark green
        if (park != null)
        {
            var green = Color.green * 0.5f;
            park.color = green;
        }
        startTime = Time.time;
    }
    

    void Update()
    {
        //sets shader's fade to a float
        picnic.SetFloat("_fade", fadeIn);

        if (fading)
        {
            //fades out shader + changes color of park & disables fireflies
            fadeIn += Time.deltaTime / 3f;

            if (fadeIn >= 1f)
                {
                    fadeIn = 1f;
                    if (park != null)
                    {
                        park.color = Color.Lerp(park.color, myColor, lerpTime);
                    }
                    if (fireflies != null)
                    {
                        fireflies.SetActive(false);
                    }
                } 
        }
    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            fading = true;
        }
    }
}
