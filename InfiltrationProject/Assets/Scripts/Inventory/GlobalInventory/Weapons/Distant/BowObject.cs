using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bow Object", menuName = "Inventory System/Items/Weapon/Bow")]
public class BowObject : WeaponObject
{
    public BowObject()
    {
        weaponType = WeaponType.Bow;
    }

}
