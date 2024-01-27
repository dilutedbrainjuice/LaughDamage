using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesArea : MonoBehaviour
{
    public List<GameObject> enemiesInEyesRange;
    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject enemy = collision.gameObject;
        if (!enemiesInEyesRange.Contains(enemy))
        {
            enemiesInEyesRange.Add(enemy);
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject enemy = collision.gameObject;

        // Check if the enemy is in the list
        if (enemiesInEyesRange.Contains(enemy))
        {
            // Remove the enemy from the list
            enemiesInEyesRange.Remove(enemy);
        }
    }
}
