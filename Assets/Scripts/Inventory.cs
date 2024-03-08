using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public event EventHandler OnItemListChanged;
    private List<Items> itemList;

    public Inventory()
    {
        itemList = new List<Items>();

        AddItem(new Items { itemType = Items.ItemType.KnightSword, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.Spear, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.Katana, amount = 1 });
    }

    public void AddItem(Items items)
    {
        //If item is stackable, check if it already exist in the inventory.
        if(items.IsStackable())
        {
            bool itemAlreadyInInventory = false;
            foreach(Items inventoryItem in itemList)
            {
                if(inventoryItem.itemType == items.itemType)
                {
                    inventoryItem.amount += items.amount;
                }
            }
            if(!itemAlreadyInInventory)
            {
                itemList.Add(items);
            }
        }
        else
        {
            itemList.Add(items);
        }
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    //Exposes the list of items.
    public List<Items> GetItemList()
    {
        return itemList;
    }
}
