using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public DynamicInventory dynamicInventory;
    public ItemDisplay[] slots;

    private void Start()
    {
        UpdateInventory();
    }

    void UpdateInventory()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if(i < dynamicInventory.items.Count)
            {
                slots[i].gameObject.SetActive(true);
                slots[i].UpdateItemDisplay(dynamicInventory.items[i].itemType.sprite, i);
            }
            else
            {
                slots[i].gameObject.SetActive(false);
            }
        }
    }

    public void DropItem(int itemIndex)
    {
        // Creates a new object and gives it the item data
        GameObject droppedItem = new GameObject();
        droppedItem.AddComponent<Rigidbody2D>();
        droppedItem.AddComponent<InstanceContainer>().item = dynamicInventory.items[itemIndex];
        GameObject itemModel = Instantiate(dynamicInventory.items[itemIndex].itemType.spriteObject, droppedItem.transform);

        // Removes the item from the inventory
        dynamicInventory.items.RemoveAt(itemIndex);

        // Updates the inventory again
        UpdateInventory();

    }    
}
