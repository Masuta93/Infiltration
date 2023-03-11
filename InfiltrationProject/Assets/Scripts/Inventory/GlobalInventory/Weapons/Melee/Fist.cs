using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Fist Object", menuName = "Inventory System/Items/Weapon/Fist")]
public class Fist : WeaponObject
{
    public Fist()
    {
        weaponType = WeaponType.Fist;
    }

}
