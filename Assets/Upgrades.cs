using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public string upgradeName;

    public Sprite upgradeSprite;

    public GameObject bodyPart;

    public GameObject bodyPartAttackRadius;

    public int maxLevel;
    public int currentLevel; // New property to track the current level

    public GameObject upgradePanel;

    public Upgrades(string name, int max)
    {
        upgradeName = name;
        maxLevel = max;
        currentLevel = 1; // Initialize current level to 1 by default

    }

    public void currentLevelUp()
    {
        currentLevel++;
        upgradePanel.SetActive(false);
        bodyPart.transform.localScale *= 1.5f;

        Time.timeScale = 1f;


    }
}
