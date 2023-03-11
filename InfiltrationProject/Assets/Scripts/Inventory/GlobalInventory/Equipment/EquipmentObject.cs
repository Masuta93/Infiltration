using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public abstract class EquipmentObject : ItemObject
{
    public EquipmentType equipmentType;
    [Header("Offense")]
    public float agilityBonus;
    public float strengthBonus;
    public float critBonus;
    public float magicBonus;
    public float attackSpeedBonus;
    public float incantationSpeedBonus;
    [Header("Defense")]
    public float magicDefenseBonus;
    public float armorBonus;
    public float vitalityBonus;
    public float manaBonus;
    private void Awake()
    {
        type = ItemType.Equipment;
    }
}
