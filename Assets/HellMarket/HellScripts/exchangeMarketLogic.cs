using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exchangeMarketLogic : MonoBehaviour
{
    public static float Bucks = 0;

    [ContextMenu("Increase Bucks")]
    public static void addBucks(float bucksToAdd)
    {
        Bucks = Bucks + bucksToAdd;
    }

}
