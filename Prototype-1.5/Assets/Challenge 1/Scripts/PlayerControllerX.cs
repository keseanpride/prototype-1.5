using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // variables
    public float vehicleSpeed = 0.5f;
    public float vehicleTiltSpeed;
    private float verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // vertical input is set from Unity's input manager
        verticalInput = Input.GetAxis("Vertical");

        // player vehicle's forward movement
        transform.Translate(Vector3.forward * vehicleSpeed);
    }
}
