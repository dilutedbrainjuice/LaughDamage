using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float lastLaughTime,lastHairTime,lastEyesTime;
    
    public float laughAttackCooldown = 2f;
    public float hairAttackCooldown = 9f;
    public float eyeAttackCooldown = 5f;
    
    public LaughRadius laughradius;
    public HairArea hairarea;
    public EyesArea eyearea;
    //public EyesArea eyearea;
    public int laughDamage = 6;
    public int hairDamage = 20;
    public int eyesDamage = 10;

    // Update is called once per frame
    void Update()
    {
        Laugh();
        HairAttack();
        EyeAttack();
    }
    void Laugh(){
        float currentTime = Time.time;
        
        if (currentTime - lastLaughTime >= laughAttackCooldown)
        {
            PerformLaugh();
            lastLaughTime = currentTime;
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
    void HairAttack(){
        float currentTime = Time.time;
        
        if (currentTime - lastHairTime >= hairAttackCooldown)
        {
            PerformHairAttack();
            lastHairTime = currentTime;
        }

        else

        {
            Debug.Log("Attack on cooldown.");
        }

    }
    void PerformHairAttack()
    {
        foreach (GameObject enemy in hairarea.enemiesInHairRange)
        {
            if (enemy != null)
            {
                Health eHealth = enemy.GetComponent<Health>();
                eHealth.health -= hairDamage;
            }
        }
        Debug.Log("Player Hair attacks!");
    }
    void EyeAttack(){
        float currentTime = Time.time;
        
        if (currentTime - lastEyesTime >= eyeAttackCooldown)
        {
            PerformEyeAttack();
            lastEyesTime = currentTime;
        }

        else

        {
            Debug.Log("Eye Attack on cooldown.");
        }

    }
    void PerformEyeAttack()
    {
        
        foreach (GameObject enemy in eyearea.enemiesInEyesRange)
        {
            if (enemy != null)
            {
                Health eHealth = enemy.GetComponent<Health>();
                eHealth.health -= eyesDamage;
            }
        }
        Debug.Log("Player Eye attacks!");
    }
    

    

    
}

