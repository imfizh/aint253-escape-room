using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScriptToilet : MonoBehaviour
{
    Animator Anim;
    public Text Tdoor_text;
    bool TDoor_Open;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        TDoor_Open = false;
        Anim = GetComponent<Animator>();
        //door = GameObject.Find("ToiletDoor1");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TDoor_Open == false)
        {
            Tdoor_text.text = "Press E to open door";
        }

    }
    private void OnTriggerStay(Collider other)
    {
        Open();
    }
    private void OnTriggerExit(Collider other)
    {
        Tdoor_text.text = "";
    }
    void Open()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Anim.SetBool("T_Open", true);
            Tdoor_text.text = "";
            TDoor_Open = true;
            door.GetComponent<BoxCollider>().enabled = false;
        }

    }
}
