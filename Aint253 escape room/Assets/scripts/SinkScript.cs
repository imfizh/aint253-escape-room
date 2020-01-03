﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkScript : MonoBehaviour
{
    public bool isCupInSink = false;
    Raycast rc;
    private void Start()
    {
        rc = GameObject.Find("Main Camera").GetComponent<Raycast>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cup")
        {
            
            isCupInSink = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cup")
        {
            
            isCupInSink = false;
        }
    }
}
