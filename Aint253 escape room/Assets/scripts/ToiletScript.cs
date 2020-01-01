using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToiletScript : MonoBehaviour
{
    Animator Anim;
    public Text toilet_text;
    bool lid_Open;
    // Start is called before the first frame update
    void Start()
    {
        lid_Open = false;
        Anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (lid_Open == false)
        {
            toilet_text.text = "Press E to open toilet";
        }

    }
    private void OnTriggerStay(Collider other)
    {
        Open();
    }
    private void OnTriggerExit(Collider other)
    {
        toilet_text.text = "";
    }
    void Open()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Anim.SetBool("Lid_Open", true);
            toilet_text.text = "";
            lid_Open = true;
        }

    }
}
