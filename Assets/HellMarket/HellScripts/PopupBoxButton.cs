using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBoxButton : MonoBehaviour
{

    public int choiceId;


    public void ButtonClick()
    {
        PopupManager.HandleButtonClick(choiceId);
    }


}
