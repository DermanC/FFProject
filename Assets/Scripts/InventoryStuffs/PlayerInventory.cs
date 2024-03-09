using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public DynamicInventory dynamicInventory;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out InstanceContainer foundItem))
        {
            dynamicInventory.AddItem(foundItem.takeItem());
        }
    }
}
