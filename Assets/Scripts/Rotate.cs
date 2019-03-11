using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(rotationSpeed, 0, 0));        
    }
}
