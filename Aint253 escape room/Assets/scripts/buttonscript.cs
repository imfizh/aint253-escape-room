using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonscript : MonoBehaviour
{
    public Text button_text;
   public void button1()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "1";
        }
    }
    public void button2()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "2";
        }
    }
    public void button3()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "3";
        }
    }
    public void button4()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "4";
        }
    }
    public void button5()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "5";
        }
    }
    public void button6()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "6";
        }
    }
    public void button7()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "7";
        }
    }
    public void button8()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "8";
        }
    }
    public void button9()
    {
        if (button_text.text.Length < 3)
        {
            button_text.text = button_text.text + "9";
        }
    }
    public void Enter()
    {
        if(button_text.text == "269")
        {
            Debug.Log("done");
        }
        button_text.text = "";
    }
}
