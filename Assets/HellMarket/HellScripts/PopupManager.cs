using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class PopupManager
{

    static Text OptionOne;
    static Text OptionTwo;
    static Text PopupTitle;
    static Text PopupClose;
    static GameObject ActivePopup;
   



    static Action<int> PopupCallback = null;
    

    public static void PopupKill()
    {
        if(GameObject.FindGameObjectWithTag("Popup") != null)
        {
            ActivePopup = GameObject.FindGameObjectWithTag("Popup");
            GameObject.Destroy(ActivePopup);
        }
        
    }
   
    public static void prompt(string title, string option1, string option2, string cancel, Action<int> callback)
    {
        ActivePopup = Resources.Load("popup") as GameObject;
        GameObject Popup = UnityEngine.Object.Instantiate(ActivePopup, new Vector3(960, 540, -2), Quaternion.identity) as GameObject;

        GameObject.FindGameObjectWithTag("Popup1").SetActive(true);
        GameObject.FindGameObjectWithTag("Popup2").SetActive(true);
        GameObject.FindGameObjectWithTag("PopupTitle").SetActive(true);
        GameObject.FindGameObjectWithTag("PopupClose").SetActive(true);

        OptionOne = GameObject.FindGameObjectWithTag("Popup1").GetComponent<Text>();
        OptionTwo = GameObject.FindGameObjectWithTag("Popup2").GetComponent<Text>();
        PopupTitle = GameObject.FindGameObjectWithTag("PopupTitle").GetComponent<Text>();
        PopupClose = GameObject.FindGameObjectWithTag("PopupClose").GetComponent<Text>();

        OptionOne.text = option1;
        OptionTwo.text = option2;
        PopupTitle.text = title;
        PopupClose.text = cancel;


        ActivePopup = GameObject.FindGameObjectWithTag("Popup");
        ActivePopup.SetActive(true);
        PopupCallback = callback;
    }

    public static void HandleButtonClick(int choiceId)
    {
        PopupCallback(choiceId);

        PopupCallback = null;

        PopupKill();

    }

    


}
