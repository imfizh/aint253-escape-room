using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Movement>().enabled = false;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<mouse_Look>().enabled = false;
    }

   
}
