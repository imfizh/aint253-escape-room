using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightScript : MonoBehaviour
{
    Animator Anim;
    public Text switch_text;
    bool switch_Open;
    private Power power;
    public AudioSource switchSound;
    // Start is called before the first frame update
    void Start()
    {
        switch_Open = false;
        Anim = GetComponent<Animator>();
        power = GameObject.FindGameObjectWithTag("switch").GetComponent<Power>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (switch_Open == false)
        {
            switch_text.text = "Press E to turn power on";
        }

    }
    private void OnTriggerStay(Collider other)
    {
        Open();
    }
    private void OnTriggerExit(Collider other)
    {
        switch_text.text = "";
    }
    void Open()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Anim.SetBool("Switch", true);
            switch_text.text = "";
            switchSound.Play();
            power.PowerOn();
            switch_Open = true;
        }

    }
}
