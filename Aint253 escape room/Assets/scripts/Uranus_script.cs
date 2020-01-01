using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranus_script : MonoBehaviour
{
    private diaTrigger dt;
    private DialogueManager dm;
    // Start is called before the first frame update
    void Start()
    {
        dt = this.GetComponent<diaTrigger>();
        dm = GameObject.Find("Dialogue manager").GetComponent<DialogueManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        dt.Call();
    }
    private void OnTriggerExit(Collider other)
    {
        dm.EndDialogue();
    }
}
