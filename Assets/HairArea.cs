using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairArea : MonoBehaviour
{
    public List<GameObject> enemiesInHairRange;
    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject enemy = collision.gameObject;
        if (!enemiesInHairRange.Contains(enemy) && enemy.tag == "Enemy")
        {
            enemiesInHairRange.Add(enemy);
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject enemy = collision.gameObject;

        // Check if the enemy is in the list
        if (enemiesInHairRange.Contains(enemy))
        {
            // Remove the enemy from the list
            enemiesInHairRange.Remove(enemy);
        }
    }
}
