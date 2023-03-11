using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New TwoHandsAxe Object", menuName = "Inventory System/Items/Weapon/TwoHandsAxe")]
public class TwoHandsAxe : WeaponObject
{
    public TwoHandsAxe()
    {
        weaponType = WeaponType.TwoHandsAxe;
    }

}
