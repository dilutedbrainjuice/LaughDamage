using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float lastLaughTime,lastHairTime,lastEyesTime,lastEarTime,lastNoseTime;
    
    public float laughAttackCooldown = 2f;
    public float hairAttackCooldown = 9f;
    public float eyeAttackCooldown = 5f;
    public float earAttackCooldown = 3f;
    public float noseAttackCooldown = 2f;
    
    public LaughRadius laughradius;
    public HairArea hairarea;
    public EyesArea eyearea;
    public EarArea earArea1;
    public EarArea earArea2;

    //public EyesArea eyearea;
    public int laughDamage = 6;
    public int hairDamage = 20;
    public int eyesDamage = 10;
    public int earDamage = 20;



    public GameObject boogerPrefab;
    public Vector3 Offset;
    public int numberOfBoogers = 10;
    public float spawnRadius = 5f;

    // Update is called once per frame
    void Update()
    {
        Laugh();
        HairAttack();
        EyeAttack();
        EarSmash();
        NoseAttack();

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
        }

    }

    void EarSmash()
    {
        float currentTime = Time.time;

        if (currentTime - lastEarTime >= earAttackCooldown)
        {
            EarAttack();
            lastEarTime = currentTime;
        }

        else

        {
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

    void EarAttack()
    {

        foreach (GameObject enemy in earArea1.enemiesInEarRange)
        {
            if (enemy != null)
            {
                Health eHealth = enemy.GetComponent<Health>();
                eHealth.health -= earDamage;

                //add code for stun
                EnemyMovement eMove = enemy.GetComponent<EnemyMovement>();
                
                eMove.stunTime = 2f;
                eMove.canMove = false;
                Debug.Log(eMove.stunTime);

            }
        }

        foreach (GameObject enemy in earArea2.enemiesInEarRange)
        {
            if (enemy != null)
            {
                Health eHealth = enemy.GetComponent<Health>();
                eHealth.health -= earDamage;

                //add code for stun
                EnemyMovement eMove = enemy.GetComponent<EnemyMovement>();
                
                eMove.stunTime = 2f;
                eMove.canMove = false;
            }
        }

        Debug.Log("Player Ear attacks!");
    }

    void NoseAttack()
    {
        float currentTime = Time.time;

        if (currentTime - lastNoseTime >= noseAttackCooldown)
        {
            SpawnBoogers();
            lastNoseTime = currentTime;
            Debug.Log("Player Nose attacks!");
        }

        else
        {
        }


    }


    void SpawnBoogers()
    {
        Vector3 spawnCenter = transform.position + Offset;

        for (int i = 0; i < numberOfBoogers; i++)
        {
            // Generate a random point within the specified spawn radius
            Vector2 randomPoint = Random.insideUnitCircle * spawnRadius;

            // Offset the random point by the spawn center
            Vector3 spawnPosition = spawnCenter + new Vector3(randomPoint.x, randomPoint.y, 0);

            // Instantiate the prefab at the random position
            Instantiate(boogerPrefab, spawnPosition, Quaternion.identity);
        }
    }



}

