using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stave Object", menuName = "Inventory System/Items/Weapon/Stave")]
public class Stave : WeaponObject
{
    public Stave()
    {
        weaponType = WeaponType.Stave;
    }

}
