using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    
    private Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            rb = other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            rb = other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
        }
    }

}
