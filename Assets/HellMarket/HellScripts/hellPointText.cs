using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hellPointText : MonoBehaviour
{
    public Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = "Score: " + scoreTracker.playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Score: " + scoreTracker.playerScore.ToString();
    }
}
