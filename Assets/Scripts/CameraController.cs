using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    
    public GameObject player;

    private Vector3 offset;

    void Start ()

    {
        offset = transform.position - player.transform.position;

    }

    // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.

    void LateUpdate ()

    {
        transform.position = player.transform.position + offset;
    }
}
