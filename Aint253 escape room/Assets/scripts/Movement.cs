using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController cc;
    float xInput;
    float zInput;
    public float speed = 12f;
    float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public AudioSource footstep;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2.0f;
        }
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        Vector3 move = transform.right * xInput + transform.forward * zInput;
        cc.Move(move * speed * Time.deltaTime);
        if (cc.velocity.magnitude > 2 && footstep.isPlaying == false)
        {
            //Debug.Log(cc.velocity.magnitude);
            footstep.Play();
        }
        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
        
    }
}
