using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject ui_object;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if(ui_object.activeInHierarchy == false)
            {
                OpenInventory();
            }
            else
            {
                CloseInventory();
            }
        }
        /*if (Input.GetKeyDown(KeyCode.I) && !isInventoryOpen)
        {
            ui_object.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.I) && isInventoryOpen)
        {
            ui_object.SetActive(false);
        }*/
    }

    public void OpenInventory()
    {
        ui_object.SetActive(true);
    }

    public void CloseInventory()
    {
        ui_object.SetActive(false);
    }
}
