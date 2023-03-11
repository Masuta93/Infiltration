using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Weapon")]

public class WeaponObject : EquipmentObject
{
    [Header("Damages Weapon")]
    public WeaponType weaponType;
    public int firstRangeDamageWeapon;
    public int secondRangeDamageWeapon;
    public float chanceDeCoupCritique;

    public WeaponObject()
    {
        type = ItemType.Weapon;
        equipmentType = EquipmentType.Weapon;
    }
}
