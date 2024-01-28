using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoogerDamage : MonoBehaviour
{
    public int boogerDamage = 5;
    public float slowTime = 0.5f;

    private void Start()
    {
        StartCoroutine(SelfDestruct());
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject enemy = collision.gameObject;

            Health eHealth = enemy.GetComponent<Health>();
            EnemyMovement eMovement = enemy.GetComponent<EnemyMovement>();


            eHealth.health -= boogerDamage;
            eMovement.slowTime = slowTime;
            eMovement.slowed = true;


        }
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
