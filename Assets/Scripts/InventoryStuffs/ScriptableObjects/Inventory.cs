using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    List<ItemInstance> items = new List<ItemInstance>();


    public void AddItem(ItemInstance itemToAdd)
    {
        items.Add(itemToAdd);
    }

    public void RemoveItem(ItemInstance itemToRemove)
    {
        items.Remove(itemToRemove);
    }
}
