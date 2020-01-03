using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float distance;
    RaycastHit whatHit;
    buttonscript bs;
    CupScript cs;
    private GameObject hot;
    private GameObject cold;
    Animator hotAnim;
    Animator coldAnim;
    private GameObject coldPS;
    private GameObject hotPS;
    private GameObject water;
    private SinkScript ss;
    private Planet_zones pz;
    private Planet_zones pzN;
    public int Temperature = 0;
    // Start is called before the first frame update
    void Start()
    {
        bs = GameObject.Find("Button_colliders").GetComponent<buttonscript>();
        cs = GameObject.Find("cup").GetComponent<CupScript>();
        ss = GameObject.Find("Sink").GetComponent<SinkScript>();
        water = GameObject.Find("Water");
        coldPS = GameObject.Find("ColdTapPS");
        coldPS.SetActive(false);
        hotPS = GameObject.Find("HotTapPS");
        hotPS.SetActive(false);
        water.SetActive(false);
        pz = GameObject.Find("Mercury_zone").GetComponent<Planet_zones>();
        pzN = GameObject.Find("Neptune_zone").GetComponent<Planet_zones>();
    }
    private IEnumerator AnimTap(float animationLength)
    {
        hotAnim.SetBool("TapOn", true);
        hotPS.SetActive(true);
        
       yield return new WaitForSeconds(animationLength);

        hotAnim.SetBool("TapOn", false);
        hotPS.SetActive(false);
        if (ss.isCupInSink == true)
        {
            water.SetActive(true);
            pz.check = true;
            pzN.check = true;
            Temperature = 3;
        }
    }
    private IEnumerator AnimTap1(float animationLength)
    {
        coldAnim.SetBool("TapOn", true);
        coldPS.SetActive(true);

        yield return new WaitForSeconds(animationLength);

        coldAnim.SetBool("TapOn", false);
        coldPS.SetActive(false);
        if (ss.isCupInSink == true)
        {
            water.SetActive(true);
            pz.check = true;
            pzN.check = true;
            Temperature = -2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distance, Color.magenta);
        
        if (Input.GetMouseButtonDown(0))
        {
            
            if (Physics.Raycast(this.transform.position, this.transform.forward, out whatHit, distance))
            {
                //Debug.Log(whatHit.collider.gameObject.name);
                if (whatHit.transform.name == "button1")
                {
                    bs.button1();
                }
                if (whatHit.transform.name == "button2")
                {
                    bs.button2();
                }
                if (whatHit.transform.name == "button3")
                {
                    bs.button3();
                }
                if (whatHit.transform.name == "button4")
                {
                    bs.button4();
                }
                if (whatHit.transform.name == "button5")
                {
                    bs.button5();
                }
                if (whatHit.transform.name == "button6")
                {
                    bs.button6();
                }
                if (whatHit.transform.name == "button7")
                {
                    bs.button7();
                }
                if (whatHit.transform.name == "button8")
                {
                    bs.button8();
                }
                if (whatHit.transform.name == "button9")
                {
                    bs.button9();
                }
                if (whatHit.transform.name == "Enter")
                {
                    bs.Enter();
                }
                if (whatHit.transform.name == "Hot_tap")
                {
                    hot = GameObject.Find("Hot_tap");
                    
                    hotAnim = hot.GetComponent<Animator>();
                    StartCoroutine(AnimTap(2.1f));
                }
                if (whatHit.transform.name == "Cold_tap")
                {
                    cold = GameObject.Find("Cold_tap");
                    
                    coldAnim = cold.GetComponent<Animator>();
                    StartCoroutine(AnimTap1(2.1f));
                }

            }
            
        }
            
    }
}
