using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousingManager
{
    //there once was a boy from tennessee
    //he lived so merry and full of glee
    //until his dog died.

    public House House;

    public static Dictionary<int, House> houses = new Dictionary<int, House>();

    public static void RegisterHouse(int houseId)
    {
        
        houses.Add(houseId, new House());
    }
    
    
    
}    

  
    

    



