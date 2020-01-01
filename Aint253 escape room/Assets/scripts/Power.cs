using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public GameObject RoomLight;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject M_Red;
    public GameObject U_Red;
    public GameObject n_Red;
    public GameObject N_Trig;
    public GameObject M_Trig;
    public GameObject U_Trig;
    public GameObject monitor;
    //public GameObject monitor_colliders;
    public GameObject n_screen;
    public GameObject m_screen;
    public GameObject u_screen;
    public GameObject n_screnn_temp;
    public GameObject m_screen_temp;
    public GameObject temperatures;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PowerOn()
    {
        RoomLight.SetActive(true);
        light1.SetActive(true);
        light2.SetActive(true);
        light3.SetActive(true);
        light4.SetActive(true);
        M_Red.SetActive(false);
        U_Red.SetActive(false);
        n_Red.SetActive(false);
        N_Trig.SetActive(true);
        M_Trig.SetActive(true);
        U_Trig.SetActive(true);
        monitor.SetActive(true);
       // monitor_colliders.SetActive(true);
        n_screen.SetActive(true);
        m_screen.SetActive(true);
        u_screen.SetActive(true);
        n_screnn_temp.SetActive(true);
        m_screen_temp.SetActive(true);
        temperatures.SetActive(true);
    }
}
