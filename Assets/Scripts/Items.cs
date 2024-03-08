using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Items
{
    public enum ItemType
    {
        //Weapon types
        KnightSword,
        Sword,
        Katana,
        NinjaBlade,
        Dagger,
        Spear,
        Bow,
        Staff,

        //Potions
        HealthPotion,
        ManaPotion,

        //Misc
        Gold,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch(itemType)
        {
            default:
            case ItemType.KnightSword:      return ItemAssets.Instance.knightSwordSprite;
            case ItemType.Sword:            return ItemAssets.Instance.swordSprite;
            case ItemType.Katana:           return ItemAssets.Instance.katanaSprite;
            case ItemType.NinjaBlade:       return ItemAssets.Instance.ninjaBladeSprite;
            case ItemType.Dagger:           return ItemAssets.Instance.daggerSprite;
            case ItemType.Spear:            return ItemAssets.Instance.spearSprite;
            case ItemType.Bow:              return ItemAssets.Instance.bowSprite;
            case ItemType.Staff:            return ItemAssets.Instance.staffSprite;
            case ItemType.HealthPotion:     return ItemAssets.Instance.healthPotionSprite;
            case ItemType.ManaPotion:       return ItemAssets.Instance.manaPotionSprite;
        }
    }

    public bool IsStackable()
    {
        switch(itemType)
        {
            default:
            case ItemType.Gold:
            case ItemType.HealthPotion:
            case ItemType.ManaPotion:
                return true;
            case ItemType.KnightSword:
            case ItemType.Sword:
            case ItemType.Katana:
            case ItemType.NinjaBlade:
            case ItemType.Dagger:
            case ItemType.Spear:
            case ItemType.Bow:
            case ItemType.Staff:
                return false;
        }
    }
}
