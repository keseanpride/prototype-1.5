using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    // variables
    public GameObject propeller;
    private float propellerSpeed = 1000.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // spin player vehicle's propeller along the y-axis
        transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);
    }
}
