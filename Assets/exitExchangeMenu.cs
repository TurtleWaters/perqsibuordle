using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitExchangeMenu : MonoBehaviour
{
    public GameObject exchangeMenu;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            exchangeMenu.SetActive(false);
        }
    }
}
