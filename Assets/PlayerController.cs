using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Vertical"))
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                transform.Translate(Vector3.up * moveSpeed, Space.World);
            }

            else if (Input.GetAxis("Vertical") < 0)
            {
                transform.Translate(Vector3.down * moveSpeed, Space.World);
            }

        }

        if (Input.GetButton("Horizontal"))
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.Translate(Vector3.right * moveSpeed, Space.World);
            }

            else if (Input.GetAxis("Horizontal") < 0)
            {
                transform.Translate(Vector3.left * moveSpeed, Space.World);
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hi");
    }
}
