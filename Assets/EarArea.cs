using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarArea : MonoBehaviour
{
    public List<GameObject> enemiesInEarRange;
    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject enemy = collision.gameObject;
        if (!enemiesInEarRange.Contains(enemy) && enemy.tag == "Enemy")
        {
            enemiesInEarRange.Add(enemy);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject enemy = collision.gameObject;

        // Check if the enemy is in the list
        if (enemiesInEarRange.Contains(enemy))
        {
            // Remove the enemy from the list
            enemiesInEarRange.Remove(enemy);
        }


    }
}
