using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventoryItemViewer : MonoBehaviour
{
    //Scriptable Objects
    [SerializeField] ItemData[] items;

    //UI references
    [SerializeField] TMP_Text itemName;
    [SerializeField] TMP_Text description;
    [SerializeField] Image icon;

    int currentIndex;

    private void Start()
    {
        currentIndex = 0;
        if(items != null && items.Length > 0)
        {
            DisplayCurrentItem();
        }
    }

    public void OnNextButtonPressed()
    {
        currentIndex++;
        if (currentIndex >= items.Length)
        {
            currentIndex = 0;
        }

        DisplayCurrentItem();
    }

    public void OnPrevButtonPressed()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = items.Length - 1;
        }

        DisplayCurrentItem();
    }

    void DisplayCurrentItem()
    {
        itemName.text = items[currentIndex].ItemName;
        description.text = items[currentIndex].Description;
        icon.sprite = items[currentIndex].Icon;
    }
}
