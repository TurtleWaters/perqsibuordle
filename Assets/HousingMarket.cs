using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousingMarket : MonoBehaviour
{

    public static Dictionary<int, GameObject> houses = new Dictionary<int, GameObject>();

    public static  void Register(int houseId, GameObject houseObject)
    {
        houses.Add(houseId, houseObject);
    }
}

