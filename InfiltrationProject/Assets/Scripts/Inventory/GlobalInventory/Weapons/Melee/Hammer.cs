using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hammer Object", menuName = "Inventory System/Items/Weapon/Hammer")]
public class Hammer : WeaponObject
{
    public Hammer()
    {
        weaponType = WeaponType.Hammer;
    }

}
