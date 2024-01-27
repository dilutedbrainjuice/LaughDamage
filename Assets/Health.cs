using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public PlayerXP playerXP;

    public int maxHealth;
    public int health;

    public int xp;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (health < 0)
        {
            //if player, lose
            //if enemy, give exp to player
            playerXP.currentXP += xp;
        }
    }

}
