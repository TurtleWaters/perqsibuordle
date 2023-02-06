using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExchangeMarketButton : MonoBehaviour
{

    public GameObject exchangeMenu;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            exchangeMenu.SetActive(true);
        }
    }
}
