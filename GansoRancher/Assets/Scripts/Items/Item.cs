using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType {
        None,
        Seed,
        Plant
    }

    public static int GetCost(ItemType itemType){
        switch(itemType) {
            default:
            case ItemType.None: return 0;
            case ItemType.Seed: return 30;
            case ItemType.Plant: return 20;
        }
    }
}
