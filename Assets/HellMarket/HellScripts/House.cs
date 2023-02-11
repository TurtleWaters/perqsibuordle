using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House 
{
    private bool isPurchased = false;
    private int furnishLevel = 0;
    private float currentValue = 100;
    private bool isOnFire = false;
    private float furnishCost;

    private float currentMultiplierRange = 0.2f;
    private float currentMultiplier = 1;
    private float Bucks = exchangeMarketLogic.Bucks;
   
    
    
    
    
    
    

    //lame ass getter functions. GRAH!

    public bool IsPurchased() 
    {
        return isPurchased;
    }
    public int FurnishLevel()
    {
        return furnishLevel;
    }
    public float CurrentValue()
    {
        return currentValue;
    }
    public bool IsOnFire()
    {
        return isOnFire;
    }
    public float FurnishCost()
    {
        furnishCost = (currentValue * 0.2f);
        return furnishCost;
    }



    //actual cool functions like cool actual functions cool
    public bool purchase()
    {
        if (isPurchased) return false;

        this.furnishLevel = 0;

        isPurchased = true;
        return true;
    }

    public bool sell()
    {
        if (isPurchased == false) return false;

        this.furnishLevel = 0;

        isPurchased = false;
        isOnFire = false;
        return true;
    }

    public double getValue()
    {
        currentValue = 100f * ((furnishLevel + 1f) / 2f) * (1f + currentMultiplier);
        return currentValue;
    }


    //0 = no burn, 1 = max burn
    public float getBurnProbability()
    {
        return furnishLevel / 5;
    }

    public bool furnish()
    {
        if (furnishLevel == 5)
        {
            return false;
        }
        if (Bucks <= (currentValue * 0.2))
        {
            Bucks = Bucks - (currentValue * 0.2f);
            furnishLevel = furnishLevel + 1;
            return true;
        } else
        {
            return false;
        }
        
    }

    public void randomizeValue()
    {
        float highestValue;
        float lowestValue = 1f - currentMultiplierRange;
        if (isOnFire)
        {
            highestValue = 1f - currentMultiplierRange + 0.2f;
        }
        else
        {
            highestValue = 1f + currentMultiplierRange;
        }
        
        currentMultiplier = Random.Range(lowestValue, highestValue);
    }

    

    


}
