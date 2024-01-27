using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Reference to the player's Transform component
    public float smoothSpeed = 0.125f;  // The speed at which the camera follows the player

    void Update()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position;
            
            transform.position = new Vector3(desiredPosition.x, desiredPosition.y, transform.position.z);
        }
    }
}
