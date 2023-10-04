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
    public float ForcePower;

    private Rigidbody _body;    

    void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7 && collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(_body.velocity * ForcePower, ForceMode.Impulse);            
        }
    }

    void Update()
    {
        if (Input.GetKey(MoveForward))
        {
            _body.AddForce(transform.right * MoveSpeed, ForceMode.VelocityChange);
        }

        if (Input.GetKey(MoveBackward))
        {
            _body.AddForce(-transform.right * MoveSpeed, ForceMode.VelocityChange);
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
