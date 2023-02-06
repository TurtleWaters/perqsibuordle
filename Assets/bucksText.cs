using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bucksText : MonoBehaviour
{

    public Text buckText;

    // Start is called before the first frame update
    void Start()
    {
        buckText.text = "Very Bucks: " + exchangeMarketLogic.Bucks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        buckText.text = "Very Bucks: " + exchangeMarketLogic.Bucks.ToString();
    }
}
