using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkScript : MonoBehaviour
{
    public bool isCupInSink = false;
    public Raycast rc;
    private void Start()
    {
        rc = GameObject.Find("Main Camera").GetComponent<Raycast>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cup")
        {
            Debug.Log("hi");
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
            Debug.Log(rc.Temperature);
            isCupInSink = false;
        }
    }
}
