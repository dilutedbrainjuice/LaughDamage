using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXP : MonoBehaviour
{
    public int currentXP;
    public int maxXP;

    // Update is called once per frame
    void Update()
    {
        if (currentXP >= maxXP)
        {
            //trigger level up
            Debug.Log("level up");
        }
    }
}
