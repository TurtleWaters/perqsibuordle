using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTextMain : MonoBehaviour
{
    public Text pointsText;

    private void Start()
    {
        pointsText.text = "Score: " + scoreTracker.playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Score: " + scoreTracker.playerScore.ToString();
    }
}
