using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardHit : MonoBehaviour
{
    public float ForcePower;

    public void LaunchImpulse()
    {
        GetComponent<Rigidbody>().AddForce(transform.right * ForcePower, ForceMode.Acceleration);
    }
}
