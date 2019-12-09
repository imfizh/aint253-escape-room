using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diaTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public void Start()
    {
        
        TriggerDialogue();
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
}
