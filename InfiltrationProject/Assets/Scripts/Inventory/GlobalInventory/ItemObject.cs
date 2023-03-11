using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Consumable,
    Weapon,
    Equipment,
    Default
}
public enum WeaponType
{
    None,
    Bow,
    OneHandAxe,
    TwoHandsAxe,
    Hammer,
    OneHandSword,
    TwoHandsSword,
    Dagger,
    Stave,
    Fist
}
public enum EquipmentType
{
    None,
    Helmet,
    Leg,
    Chest,
    Feet,
    Hands,
    Shoulder,
    Waist,
    Wrist,
    Weapon,
    Trinket,
    Necklace
}
public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    [HideInInspector]public ItemType type;
    [TextArea(15, 25)] public string description;
}
