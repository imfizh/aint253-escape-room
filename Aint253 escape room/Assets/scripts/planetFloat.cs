using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetFloat : MonoBehaviour
{
    public float Hoverforce = 20f;
    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(Vector3.up * Hoverforce, ForceMode.Acceleration);
    }
}
