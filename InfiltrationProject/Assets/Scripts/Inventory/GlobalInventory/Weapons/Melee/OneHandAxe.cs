using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New OneHandAxe Object", menuName = "Inventory System/Items/Weapon/OneHandAxe")]
public class OneHandAxe : WeaponObject
{
    public OneHandAxe()
    {
        weaponType = WeaponType.OneHandAxe;
    }

}
