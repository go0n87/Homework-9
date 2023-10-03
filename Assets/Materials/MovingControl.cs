using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingControl : MonoBehaviour
{
    public KeyCode MoveForward;
    public KeyCode MoveBackward;
    public KeyCode RotateLeft;
    public KeyCode RotateRight;

    public float MoveSpeed;

    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(MoveForward))
        {            
            body.AddForce(transform.right * MoveSpeed, ForceMode.VelocityChange);
        }

        if (Input.GetKey(MoveBackward))
        {           
            body.AddForce(-transform.right * MoveSpeed, ForceMode.VelocityChange);
        }

        if (Input.GetKey(RotateLeft))
        {
            transform.Rotate(0, -10 * MoveSpeed, 0);
        }

        if (Input.GetKey(RotateRight))
        {
            transform.Rotate(0, 10 * MoveSpeed, 0);
        }
    }
}
