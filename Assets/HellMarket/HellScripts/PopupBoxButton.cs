using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBoxButton : MonoBehaviour
{

    public int choiceId;


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PopupManager.HandleButtonClick(choiceId);
        }
    }



}
