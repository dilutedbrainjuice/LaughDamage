using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUp : MonoBehaviour
{
    public Image upgradeImage1;
    public Image upgradeImage2;
    public Image upgradeImage3;

    public TMP_Text upgradeText1;
    public TMP_Text upgradeText2;
    public TMP_Text upgradeText3;

    public Button button1;
    public Button button2;
    public Button button3;

    public Upgrades upgrade1;
    public Upgrades upgrade2;
    public Upgrades upgrade3;
    public Upgrades upgrade4;
    public Upgrades upgrade5;

    public Upgrades tempUpgrade1;
    public Upgrades tempUpgrade2;
    public Upgrades tempUpgrade3;


    // Update is called once per frame
    void Update()
    {
    }

    public void randomUpgradeChosen()
    {

         List<Upgrades> upgradeList = new List<Upgrades>();

        if (upgrade1.currentLevel != 5)
        {
            upgradeList.Add(upgrade1);
        }

        if (upgrade2.currentLevel != 5)
        {
            upgradeList.Add(upgrade2);
        }

        if (upgrade3.currentLevel != 5)
        {
            upgradeList.Add(upgrade3);
        }

        if (upgrade4.currentLevel != 5)
        {
            upgradeList.Add(upgrade4);
        }

        if (upgrade5.currentLevel != 5)
        {
            upgradeList.Add(upgrade5);
        }

        ShuffleList(upgradeList);

        tempUpgrade1 = upgradeList[0];
        tempUpgrade2 = upgradeList[1];
        tempUpgrade3 = upgradeList[2];


        Levelling(tempUpgrade1, tempUpgrade2, tempUpgrade3);
    }


    void Levelling(Upgrades upgrade1, Upgrades upgrade2, Upgrades upgrade3)
    {


        upgradeImage1.sprite = upgrade1.upgradeSprite;
        upgradeImage2.sprite = upgrade2.upgradeSprite;
        upgradeImage3.sprite = upgrade3.upgradeSprite;

        upgradeText1.text = upgrade1.upgradeName;
        upgradeText2.text = upgrade2.upgradeName;
        upgradeText3.text = upgrade3.upgradeName;


        button1.onClick.AddListener(upgrade1.currentLevelUp);
        button2.onClick.AddListener(upgrade2.currentLevelUp);
        button3.onClick.AddListener(upgrade3.currentLevelUp);


    }


    void ShuffleList<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
