using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseScript : MonoBehaviour
{
    public bool isPurchased = false;
    public int furnishLevel = 0;
    public float currentValue = 100;
    private float valueMultiplier = 0.2f;
    private float timer = 0;
    private float valueChangeRate = 1;

    //Increases timer every second until it meets the rate of change, then randomly changes the value multiplier.
    void Update()
    {
        if (timer < valueChangeRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            getValue();
            timer = 0;
        }
    }

    //Evaluates the pricing of the house using the furnish level and a random range.
    //I want to weight this so that it has trends of up and down, but im not sure how.
    public float getValue()
    {
        float lowestPoint = 1.0f - valueMultiplier;
        float highestPoint = 1.0f + valueMultiplier;
        currentValue = currentValue * ((furnishLevel + 1f) / 2f) * Random.Range(lowestPoint, highestPoint);
        return currentValue;
    }

    //Purchasing the house :D returns true if it did it
    public bool purchase()
    {
        if (isPurchased == true) return false;

        this.furnishLevel = 0;

        isPurchased = true;
        return true;
    }

    //Burn probability ranges from 0 to 1, 0 = none 1 = max
    public float getBurnProbability()
    {
        return furnishLevel / 5;
    }

    public bool furnish()
    {
        if (furnishLevel == 5)
        {
            //cant furnish past five
            return false;
        }
        else if (exchangeMarketLogic.Bucks >= currentValue * 0.2)
        {
            //i know this is super decompressed and you can compress it if you want to
            //its just easier for me to read this way 
            currentValue = currentValue - (currentValue * 0.1f);
            furnishLevel = furnishLevel + 1;
            return true;
        }
        else
        {
            //not enough vbucks!
            return false;
        }
    }

}
