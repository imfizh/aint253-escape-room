using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uranus_script : MonoBehaviour
{
    private diaTrigger dt;
    private DialogueManager dm;
    public Text inter_text;
    bool inter = false;
    // Start is called before the first frame update
    void Start()
    {
        dt = this.GetComponent<diaTrigger>();
        dm = GameObject.Find("Dialogue manager").GetComponent<DialogueManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        inter_text.text = "Press E to read";
        //dt.Call();
    }
    private void OnTriggerExit(Collider other)
    {
        inter_text.text = "";
        if (inter == true)
        {
            dm.EndDialogue();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inter = true;
            inter_text.text = "";
            interact();
        }
    }
    public void interact()
    {
        dt.Call();
    }
}
