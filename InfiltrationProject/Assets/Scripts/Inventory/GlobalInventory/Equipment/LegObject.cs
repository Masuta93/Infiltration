using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Leg Object", menuName = "Inventory System/Items/Equipment/Leg")]
public class LegObject : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Leg;
    }
}
