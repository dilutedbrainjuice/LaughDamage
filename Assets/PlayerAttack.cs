using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float lastAttackTime;
    public float attackCooldown = 2f;
    public LaughRadius laughradius;
    public int laughDamage = 6;

    // Update is called once per frame
    void Update()
    {
        
        Laugh();
        
    }

    

    void Laugh(){
        float currentTime = Time.time;
        
        if (currentTime - lastAttackTime >= attackCooldown)
        {
            PerformLaugh();
            lastAttackTime = currentTime;
        }

        else

        {
            Debug.Log("Attack on cooldown.");
        }

    }

    void PerformLaugh()
    {
        
        foreach (GameObject enemy in laughradius.enemiesInRange)
        {
            if (enemy != null)
            {
                Health eHealth = enemy.GetComponent<Health>();
                eHealth.health -= laughDamage;
            }
            
        }
        
        Debug.Log("Player laugh attacks!");
    }

    

    
}

