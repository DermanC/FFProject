using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DynamicInventory : ScriptableObject
{
    public int maxItems = 10;
    public List<ItemInstance> items = new List<ItemInstance>();

    public bool AddItem(ItemInstance itemToAdd)
    {
        // Find an empty slot if there is one.
        for(int i = 0; i < items.Count; i++)
        {
            if(items[i] == null)
            {
                items[i] = itemToAdd;
                return true;
            }
        }

        // Adds a new item if the inventory has space
        if(items.Count < maxItems)
        {
            items.Add(itemToAdd);
            return true;
        }

        Debug.Log("Inventory is full!");
        return false;
    }
}
