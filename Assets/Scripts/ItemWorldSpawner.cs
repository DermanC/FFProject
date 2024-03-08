using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorldSpawner : MonoBehaviour
{
    public Items items;

    private void Start()
    {
        ItemWorld.SpawnItemWorld(transform.position, items);
        Destroy(gameObject);
    }
}
