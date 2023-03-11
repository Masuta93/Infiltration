using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dagger Object", menuName = "Inventory System/Items/Weapon/Dagger")]
public class Dagger : WeaponObject
{
    public Dagger()
    {
        weaponType = WeaponType.Dagger;
    }

}
