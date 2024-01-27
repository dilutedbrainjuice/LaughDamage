using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public GameObject player;
    public PlayerXP playerXP;
    public GameObject text;

    public int maxHealth;
    public int health;

    public int xp;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerXP = player.GetComponent<PlayerXP>();
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
                Destroy(gameObject);
            }
            
        }
    }

}
