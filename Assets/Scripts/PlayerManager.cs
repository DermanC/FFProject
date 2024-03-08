using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;

    private Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        /*ItemWorld.SpawnItemWorld(new Vector3(5, 0), new Items { itemType = Items.ItemType.KnightSword, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(-5, 0), new Items { itemType = Items.ItemType.Katana, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(0, -5), new Items { itemType = Items.ItemType.Spear, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(5, -5), new Items { itemType = Items.ItemType.Dagger, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(0, -3), new Items { itemType = Items.ItemType.Bow, amount = 1 });*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ItemWorld itemWorld = collision.GetComponent<ItemWorld>();
        if(itemWorld != null)
        {
            //Touching item
            inventory.AddItem(itemWorld.GetItems());
            itemWorld.DestroySelf();
        }
    }

}
