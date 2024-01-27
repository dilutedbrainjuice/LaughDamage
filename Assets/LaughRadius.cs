using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class LaughRadius : MonoBehaviour
{
    public List<GameObject> enemiesInRange;
    private void OnTriggerStay2D(Collider2D collision)
    {
        

        GameObject enemy = collision.gameObject;
        if (!enemiesInRange.Contains(enemy))
        {
            enemiesInRange.Add(enemy);
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject enemy = collision.gameObject;

        // Check if the enemy is in the list
        if (enemiesInRange.Contains(enemy))
        {
            // Remove the enemy from the list
            enemiesInRange.Remove(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }


}
