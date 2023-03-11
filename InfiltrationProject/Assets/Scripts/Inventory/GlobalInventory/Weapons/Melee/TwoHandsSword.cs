using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TwoHandsSword Object", menuName = "Inventory System/Items/Weapon/TwoHandsSword")]
public class TwoHandsSword : WeaponObject
{
    public TwoHandsSword()
    {
        weaponType = WeaponType.TwoHandsSword;
    }

}
