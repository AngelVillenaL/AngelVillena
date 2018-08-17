using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Item : ScriptableObject
{
    public Sprite itemIcon;
    public string itemName;
    public int SellPrice;

}

[System.Serializable]
public class StatValue
{
    public MainStat TheStat;
    public int TheValue;

    public StatValue(MainStat MS, int Value)
    {
        TheStat = MS;
        TheValue = Value;
    }
}