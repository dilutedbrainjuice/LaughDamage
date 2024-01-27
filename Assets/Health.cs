using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public PlayerXP playerXP;
    public GameObject text;

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
            if (gameObject.tag == "Player")
            {
                text.SetActive(true);
            }
            //if enemy, give exp to player
            else
            {
                playerXP.currentXP += xp;
            }
            
        }
    }

}
