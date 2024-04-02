using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowInventoryItems : MonoBehaviour
{
    public ItemData[] item;

    public TMP_Text itemNameText;
    public TMP_Text descriptionText;
    public Image imageItem;

    int currentIndex;

    private void Start()
    {
        currentIndex = 0;
        DisplayItems();
    }
    private void Update()
    {
        InventoryToggle();
    }

    public void OnNextButton()
    {
        currentIndex++;
        if (currentIndex >= item.Length)
        {
            currentIndex = 0;
        }
        DisplayItems();
    }

    public void OnPreviousButton()
    {
        currentIndex--;
        if(currentIndex < 0)
        {
            currentIndex = item.Length - 1;
        }
        DisplayItems();
    }

    public void DisplayItems()
    {
        itemNameText.text = item[currentIndex].itemName;
        descriptionText.text = item[currentIndex].description;
        imageItem.sprite = item[currentIndex].itemImage;
    }


    bool inventoryOpen = false;
    public void InventoryToggle()
    {
        if(inventoryOpen && Input.GetKeyDown(KeyCode.I))
        {
            gameObject.SetActive(true);
        }
        if(!inventoryOpen && Input.GetKeyDown(KeyCode.I))
        {
            gameObject.SetActive(false);
        }
    }
}
