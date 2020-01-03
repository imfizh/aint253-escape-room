using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Loadscene()
    {
        SceneManager.LoadScene("RoomScene");
    }
    public void LoadEndScreen()
    {
        SceneManager.LoadScene("EndScreen");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
