using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTracker : MonoBehaviour
{
    public static float playerScore = 0;

    [ContextMenu("Increase Score")]
    public static void addScore(float scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
    }

}
