using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Animator animator;
    public Text DialogueText;
    private Queue<string> sentences;
    bool next = false;
    //public bool MoveActivate = false;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && next == true)
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue (Dialogue dialogue)
    {
        animator.SetBool("isOpen",true);
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
        
        
    }
    public void DisplayNextSentence()
    {
        next = true;
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        
    }
    IEnumerator TypeSentence (string sentence)
    {
        DialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            DialogueText.text += letter;
            yield return null;
        }
    }
    public void EndDialogue()
    {
        next = false;
        //MoveActivate = true;
        animator.SetBool("isOpen", false);
    }
}
