using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New OneHandSword Object", menuName = "Inventory System/Items/Weapon/OneHandSword")]
public class OneHandSword : WeaponObject
{
    public OneHandSword()
    {
        weaponType = WeaponType.OneHandSword;
    }

}
