using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupScript : MonoBehaviour
{
    public GameObject item;
    public GameObject tempParent;
    public GameObject guide;
    public Transform player;
    float distance;
    bool inRange;
    // Start is called before the first frame update
    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
    }
    private void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.position);
        if (distance<=2)
        {
            inRange = true;
        }
        else
        {
            inRange = false;
        }
    }

    void OnMouseDown()
    {
        if (inRange == true)
        {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
            item.transform.parent = tempParent.transform;
        }
    }
    //public void pickUp()
    //{
    //    item.GetComponent<Rigidbody>().useGravity = false;
    //    item.GetComponent<Rigidbody>().isKinematic = true;
    //    item.transform.position = guide.transform.position;
    //    item.transform.rotation = guide.transform.rotation;
    //    item.transform.parent = tempParent.transform;
    //}
    void OnMouseUp()
    {
        if (inRange == true)
        {
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;
        }
        
    }
}
