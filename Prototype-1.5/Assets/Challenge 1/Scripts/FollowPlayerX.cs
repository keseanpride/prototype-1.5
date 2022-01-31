using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{

    // variables
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(25, 0, 0);

    void Start()
    {

    }

    void Update()
    {
        // main camera's transform is set relative to player vehicle's transform + its own offset
        transform.position = player.transform.position + cameraOffset;

    }
}
