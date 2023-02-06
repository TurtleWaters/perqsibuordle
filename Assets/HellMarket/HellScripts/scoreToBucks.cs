using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreToBucks : MonoBehaviour
{
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && scoreTracker.playerScore >= 10)
        {
            exchangeMarketLogic.addBucks(100);
            scoreTracker.addScore(-10);
        }
    }
}
