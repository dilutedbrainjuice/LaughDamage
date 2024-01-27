using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{


    
    private int damage = 3;
    public Transform enemyPrefab;
    
    private GameObject player;
    private Transform enemy;
    
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        enemy = Instantiate(enemyPrefab) as Transform;
        if (collision.gameObject.tag == "Player") { 
                    Debug.Log(collision.gameObject.name); 
                    player = collision.gameObject; 
                    Health playerHealth = player.GetComponent<Health>();
                    playerHealth.health -= damage;
                    Physics2D.IgnoreCollision(enemy.GetComponent<Collider2D>(), player.GetComponent<Collider2D>(),true);
                    StartCoroutine(wait());
                    
                    
                    
                    
        }
        
        
    }
    
    IEnumerator wait(){
        
        yield return new WaitForSeconds(1);
        Physics2D.IgnoreCollision(enemy.GetComponent<Collider2D>(), player.GetComponent<Collider2D>(),false);
        
        
    }
    
    
    
    
    
}


