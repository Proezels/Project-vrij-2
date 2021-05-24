using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public float fadeIn = 0f; 
    public Material picnic;
    public Material park;
    public bool fading = false;
    Color colorEnd = Color.gray;
    float duration = 1f;
    float startTime;
    public GameObject fireflies;

    void Start()
    {
    //sets starting color to dark green
        var green = Color.green * 0.5f;
        park.color = green;
        startTime = Time.time;
    }
    

    void Update()
    {
        //sets shader's fade to a float
        picnic.SetFloat("_fade", fadeIn);

        if (fading)
        {
            //fades out shader + changes color of park & disables fireflies
            fadeIn += Time.deltaTime;
            float t = (Time.time - startTime) * duration;
            

            if (fadeIn >= 1f)
                {
                    fadeIn = 1f;
                    fading = false;
                    park.color = Color.Lerp(park.color, colorEnd, t);
                    fireflies.SetActive(false);
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
