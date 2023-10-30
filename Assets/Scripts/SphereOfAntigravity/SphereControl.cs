using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    public KeyCode MoveForward;
    public KeyCode MoveBackward;
    public KeyCode RotateLeft;
    public KeyCode RotateRight;
    
    void Update()
    {
        if (Input.GetKey(MoveForward))
        {
            transform.position += Vector3.back / 50;
        }

        if (Input.GetKey(MoveBackward))
        {
            transform.position += Vector3.forward / 50;
        }

        if (Input.GetKey(RotateLeft))
        {
            transform.position += Vector3.right / 50;
        }

        if (Input.GetKey(RotateRight))
        {
            transform.position += Vector3.left / 50;
        }
    }
}
