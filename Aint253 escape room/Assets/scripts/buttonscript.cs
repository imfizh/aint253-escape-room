using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonscript : MonoBehaviour
{
    public Text button_text;
    private LoadScene ls;
    public GameObject buttons;
    public GameObject enter;
   public void button1()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "1";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void button2()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "2";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void button3()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "3";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void button4()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "4";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void button5()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "5";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void button6()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "6";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void button7()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "7";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void button8()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "8";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void button9()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "9";
            buttons.GetComponent<AudioSource>().Play();
        }
    }
    public void Enter()
    {
        if(button_text.text == "269")
        {
            Debug.Log("done");
            ls = GameObject.Find("SceneLoader").GetComponent<LoadScene>();
            ls.LoadEndScreen();
        }
        else
        {
            enter.GetComponent<AudioSource>().Play();
        }
        button_text.text = "";
    }
}
