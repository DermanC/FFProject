using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceContainer : MonoBehaviour
{
    public ItemInstance item;

    public ItemInstance takeItem()
    {
        Destroy(gameObject);
        return item;
    }



}
