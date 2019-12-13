using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade_in : MonoBehaviour
{
    public Image BlackImage;
    //public DialogueManager dm;
    
    // Start is called before the first frame update
    void Start()
    {
        BlackImage.canvasRenderer.SetAlpha(1.0f);
        fadeIn();
        //GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = false;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<mouse_Look>().enabled = false;
        StartCoroutine(wait());
        StartCoroutine(look_back());
        
    }
    public void Update()
    {
        //if (dm.MoveActivate == true)
        //{
        //    GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = true;
        //}

    }

    void fadeIn()
    {
        BlackImage.CrossFadeAlpha(0, 3, false);
    }
    void Anims()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().SetTrigger("test");
        GameObject.Find("phone").GetComponent<Animator>().SetTrigger("phone_trigger");
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        Anims();
    }
    IEnumerator look_back()
    {
        yield return new WaitForSeconds(4);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<mouse_Look>().enabled = true;
    }
}
