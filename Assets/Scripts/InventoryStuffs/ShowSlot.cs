using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowSlot : MonoBehaviour
{
    //public ItemSlot[] slot;
    public ItemSlot slot;

    public TMP_Text itemName;
    public Image slotImage;

    public int currentIndex;

    private void Start()
    {
        itemName.text = slot.itemName;
        slotImage.sprite = slot.itemIcon;
    }

}
