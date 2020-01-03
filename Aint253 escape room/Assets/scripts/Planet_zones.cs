using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Planet_zones : MonoBehaviour
{
    public GameObject water;
    public int Mercury_Value = 423;
    public int Neptune_Value = -225;
    public TextMeshProUGUI mt;
    public TextMeshProUGUI nt;
    Raycast rc;

    public GameObject item;
    public GameObject tempParent;
    public GameObject guide;
    public bool check = false;
    public GameObject cup_Water;
    // Start is called before the first frame update
    void Start()
    {
        mt.text = Mercury_Value.ToString() + "°C";
        nt.text = Neptune_Value.ToString() + "°C";
        water = GameObject.Find("Water");
        rc = GameObject.Find("Main Camera").GetComponent<Raycast>();
    }
    private void Update()
    {
        if (Mercury_Value == 427)
        {
            mt.text = "9";
        }
        if (Neptune_Value == -218)
        {
            nt.text = "6";
        }
    }
    private IEnumerator CupFloat(float time)
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
        check = false;
        cup_Water.SetActive(true);
        yield return new WaitForSeconds(time);
        cup_Water.SetActive(false);
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        item.transform.position = guide.transform.position;

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cup")
        {
            if (this.name == "Mercury_zone")
            {
                Mercury_Value = Mercury_Value + rc.Temperature;
                mt.text = Mercury_Value.ToString() + "°C";
                rc.Temperature = 0;
                if(check == true)
                {
                    StartCoroutine(CupFloat(1));
                }
                

            }
            if (this.name == "Neptune_zone")
            {
                Neptune_Value = Neptune_Value + rc.Temperature;
                nt.text = Neptune_Value.ToString() + "°C";
                rc.Temperature = 0;
                if (check == true)
                {
                    StartCoroutine(CupFloat(1));
                }
            }
            water.SetActive(false);
        }
    }
}
