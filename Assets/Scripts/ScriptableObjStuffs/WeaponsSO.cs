using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapons", menuName = "CreateWeapon")]
public class WeaponsSO : ScriptableObject
{
    [SerializeField] public Sprite sprite;
    [SerializeField] public string wepName;
    [SerializeField] public string description;
    [SerializeField] public string element;
    [SerializeField] public float physAttack;
    [SerializeField] public float magiAttack;
    [SerializeField] public string effect;
    [SerializeField] public string boosts;


}
