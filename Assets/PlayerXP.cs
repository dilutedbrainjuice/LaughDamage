using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXP : MonoBehaviour
{
    public int currentXP;
    public int maxXP;

    public GameObject upgradePanel;
    
    public LevelUp levelUpManager;

    // Update is called once per frame
    void Update()
    {
        if (currentXP >= maxXP)
        {
            //trigger level up
            maxXP *= 2;
            currentXP = 0;

            upgradePanel.SetActive(true);
            
            levelUpManager.randomUpgradeChosen();

            Time.timeScale = 0f;

            

            Debug.Log("level up");
        }
    }
}
