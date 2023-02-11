using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    public int HouseId;
    public SpriteRenderer SpriteRenderer;
    public Sprite EmptySprite;
    public Sprite PurchasedSprite;
    public Sprite BurnedSprite;

    public void Start()
    {
        HousingManager.RegisterHouse(HouseId);
    }

    public void Update()
    {
        //update if the house is owned
        if (HousingManager.houses[HouseId].IsPurchased())
        {
            SpriteRenderer.sprite = PurchasedSprite;
        }
        else
        {
            SpriteRenderer.sprite = EmptySprite;
        }

        //check if its burning
        if (HousingManager.houses[HouseId].IsOnFire())
        {
            SpriteRenderer.sprite = BurnedSprite;
        }

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (HousingManager.houses[HouseId].IsPurchased())
            {
                PopupManager.prompt("Dinner?", "Sell", "Furnish", "Nothing.", delegate(int choiceId)
                {
                    switch (choiceId)
                    {
                        //0 is cancel, 1 and 2 are choices 1 and 2!
                        case 0:
                            break;
                        case 1:
                            HousingManager.houses[HouseId].sell();
                            break;
                        case 2:
                            HousingManager.houses[HouseId].furnish();
                            break;
                    }
                });
            }
            else
            {
                PopupManager.prompt("Invest", "Buy", "Bye", "Goodbye", delegate(int choiceId)
                {
                    if(choiceId == 1)
                    {
                       HousingManager.houses[HouseId].purchase();
                }
                });
            }
        }
    }
}
