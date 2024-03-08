using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Transform pfItemWorld;

    public Sprite knightSwordSprite;
    public Sprite swordSprite;
    public Sprite katanaSprite;
    public Sprite ninjaBladeSprite;
    public Sprite daggerSprite;
    public Sprite spearSprite;
    public Sprite bowSprite;
    public Sprite staffSprite;
    public Sprite healthPotionSprite;
    public Sprite manaPotionSprite;
}
