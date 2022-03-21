using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
    // variables
    public float vehicleSpeed = 0.5f;
    public float vehicleTiltSpeed = 50.0f;
    private float verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // vertical input is set from Unity's input manager
        verticalInput = Input.GetAxis("Vertical");

        // player vehicle's forward & tilting movement
        transform.Translate(Vector3.forward * vehicleSpeed);
        transform.Rotate(Vector3.right, vehicleTiltSpeed * Time.deltaTime * verticalInput);

        // reload scene from player input
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Challenge 1");
        }
    }
}
