using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public bool maskOn = false;
    public Animator anim;

    public AudioClip[] footsteps;
    public float stepTimer = 0f;
    public float stepSpeed = 100f;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        // character movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        
        if (controller.velocity != Vector3.zero)
        {
            stepTimer = stepTimer + 1f;
            if (stepTimer == stepSpeed)
            {
                steps();
                stepTimer = 0f;
            }
        }
        else if (controller.velocity == Vector3.zero)
        {
            stepTimer = 0f;
        }
    }

    void stopAnim()
    {
        anim.enabled = !anim.enabled;
    }

    void steps()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = footsteps[Random.Range(0, footsteps.Length)];
        audio.PlayOneShot(audio.clip);
    }
}
