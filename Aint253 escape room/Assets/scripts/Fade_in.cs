using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade_in : MonoBehaviour
{
    public Image BlackImage;
    //public DialogueManager dm;
    public AudioSource phone;
    bool phone_gone = false;
    // Start is called before the first frame update
    void Start()
    {
        BlackImage.canvasRenderer.SetAlpha(1.0f);
        fadeIn();
        //GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().enabled = false;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<mouse_Look>().enabled = false;
        phone = GameObject.Find("phone").GetComponent<AudioSource>();
        StartCoroutine(wait());
        StartCoroutine(look_back());
        
    }
    public void Update()
    {
        if (phone_gone == false)
        {
            if (phone.volume < 0.3)
            {
                phone.volume = phone.volume + 0.003f;
            }
        }

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
        phone_gone = true;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<mouse_Look>().enabled = true;
    }
}
