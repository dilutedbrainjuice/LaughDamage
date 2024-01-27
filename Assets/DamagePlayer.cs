using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.gameObject.name);

            GameObject player = collision.gameObject;
            Health playerHealth = player.GetComponent<Health>();

            playerHealth.health -= 3;

        }
    }
}
