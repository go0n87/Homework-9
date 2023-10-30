using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploseScript : MonoBehaviour
{
    public float Radius;
    public float Power;

    private float _radiusOfDistance;

    public void Explosion()
    {

        Rigidbody[] Cubes = FindObjectsOfType<Rigidbody>();        

        foreach (Rigidbody _cube in Cubes)
        {            

            _radiusOfDistance = Vector3.Distance(transform.position, _cube.transform.position);

            if (_radiusOfDistance < Radius)
            { 
                Vector3 direction = _cube.transform.position - transform.position;

                _cube.AddForce(direction.normalized * Power * (Radius - _radiusOfDistance), ForceMode.Impulse);
            }
        }
            
    }
}
