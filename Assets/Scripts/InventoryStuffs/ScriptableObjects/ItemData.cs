using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Item Data")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite itemImage;


}
