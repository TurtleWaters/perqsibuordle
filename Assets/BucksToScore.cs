using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucksToScore : MonoBehaviour
{
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && exchangeMarketLogic.Bucks >= 100)
        {

            
                exchangeMarketLogic.addBucks(-100);
                scoreTracker.addScore(10);
            
        }
    }
}
