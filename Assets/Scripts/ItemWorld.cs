using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemWorld : MonoBehaviour
{
    public static ItemWorld SpawnItemWorld(Vector3 position, Items items)
    {
        Transform transform = Instantiate(ItemAssets.Instance.pfItemWorld, position, Quaternion.identity);

        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.SetItems(items);

        return itemWorld;
    }

    private Items items;
    private SpriteRenderer spriteRenderer;
    private TextMeshPro textMeshPro;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }

    public void SetItems(Items items)
    {
        this.items = items;
        spriteRenderer.sprite = items.GetSprite();
        if(items.amount > 1)
        {
            textMeshPro.SetText(items.amount.ToString());
        }
        else
        {
            textMeshPro.SetText("");
        }
    }

    public Items GetItems()
    {
        return items;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
