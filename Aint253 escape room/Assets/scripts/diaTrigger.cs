using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diaTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public void Start()
    {
        if (this.name == "Canvas")
        {
            TriggerDialogue();
        }
        
    }
    public void TriggerDialogue()
    {
        
        StartCoroutine(phone());
    }
    IEnumerator phone()
    {
        
        yield return new WaitForSeconds(4);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
    public void Call()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
