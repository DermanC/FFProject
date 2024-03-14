using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "In Game Item")]
public class ItemData : ScriptableObject
{
    [Header("UI")]
    public string ItemName;
    public Sprite Icon;
    public ItemCategory Category;
    [TextArea]

    public string Description;

}


public enum ItemCategory
{
    Weapon, Armour, Consumable, QuestItem, Crafting
}
