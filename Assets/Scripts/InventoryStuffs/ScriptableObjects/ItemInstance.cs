using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInstance
{
    public ItemData itemType;
    public int lvlRequirement;
    public int attack;
    public int defense;

    public ItemInstance(ItemData itemData, int lvlRequirement, int attack, int defense)
    {
        itemType = itemData;
        this.lvlRequirement = lvlRequirement;
        this.attack = attack;
        this.defense = defense;
    }
}
