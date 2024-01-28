using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{


    
    private int damage = 3;

    
    private GameObject player;

    private Collider2D enemyCollider;
    
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.tag == "Player") { 
                    Debug.Log(collision.gameObject.name); 
                    player = collision.gameObject; 
                    Health playerHealth = player.GetComponent<Health>();

                    enemyCollider = gameObject.GetComponent<Collider2D>();

                    playerHealth.health -= damage;
                    Physics2D.IgnoreCollision(enemyCollider, player.GetComponent<Collider2D>(),true);
                    StartCoroutine(wait());
                    
                    
                    
                    
        }
        
        
    }
    
    IEnumerator wait(){
        
        yield return new WaitForSeconds(1);
        Physics2D.IgnoreCollision(enemyCollider, player.GetComponent<Collider2D>(),false);
        
        
    }
    
    
    
    
    
}


