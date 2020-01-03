using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    Animator Anim;
    public Text door_text;
    bool Door_Open;
    public AudioSource doorSound;
    // Start is called before the first frame update
    void Start()
    {
        Door_Open = false;
        Anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Door_Open == false)
        {
            door_text.text = "Press E to open door";
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        Open();
    }
    private void OnTriggerExit(Collider other)
    {
        door_text.text = "";
    }
    void Open()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Anim.SetBool("Open", true);
            door_text.text = "";
            Door_Open = true;
            doorSound.Play();
        }
        
    }
}
