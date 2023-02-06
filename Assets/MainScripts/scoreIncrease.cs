using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreIncrease : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scoreTracker.playerScore = scoreTracker.playerScore + 100;
        }
    }


}
