using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_Look : MonoBehaviour
{

    public float mouse_Sens = 100.0f;
    public Transform PlayerBody;
    float xMouse;
    float yMouse;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        xMouse = Input.GetAxis("Mouse X") * mouse_Sens * Time.deltaTime;
        yMouse = Input.GetAxis("Mouse Y") * mouse_Sens * Time.deltaTime;
        xRotation -= yMouse;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * xMouse);
    }
}
