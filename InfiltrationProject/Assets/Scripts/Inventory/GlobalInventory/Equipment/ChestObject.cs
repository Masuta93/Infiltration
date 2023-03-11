using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Chest Object", menuName = "Inventory System/Items/Equipment/Chest")]
public class ChestObject : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Chest;
    }
}
