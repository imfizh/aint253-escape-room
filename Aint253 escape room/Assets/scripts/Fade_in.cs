using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade_in : MonoBehaviour
{
    public Image BlackImage;
    // Start is called before the first frame update
    void Start()
    {
        BlackImage.canvasRenderer.SetAlpha(1.0f);
        fadeIn();
        StartCoroutine(wait());
        
        
    }

    void fadeIn()
    {
        BlackImage.CrossFadeAlpha(0, 3, false);
    }
    void Anims()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().SetTrigger("test");
        GameObject.Find("phone").GetComponent<Animator>().SetTrigger("phone_trigger");
        //Destroy(GameObject.Find("phone"));
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        Anims();
    }
}
