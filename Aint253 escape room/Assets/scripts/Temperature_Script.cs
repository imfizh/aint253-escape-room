using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature_Script : MonoBehaviour
{
    public Text Merc_text;
    public Text Nep_text;
    public int Mercury_Value = 423;
    public int Neptune_Value = -225;
    // Start is called before the first frame update
    void Start()
    {
        Merc_text.text = Mercury_Value.ToString() + "°C";
        Nep_text.text = Neptune_Value.ToString() + "°C";
    }

    public void ChangeTemperature()
    {

    }
}
