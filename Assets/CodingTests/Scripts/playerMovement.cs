using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    public bool teleport = false;
    public Transform startCoord;
    public bool maskOn = false;
    public Animator anim;
    
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
    
        if (teleport)
        {
            gameObject.transform.position = startCoord.transform.position;
            teleport = false;
        }
    }

    void stopAnim()
    {
        anim.enabled = !anim.enabled;
    }
}
