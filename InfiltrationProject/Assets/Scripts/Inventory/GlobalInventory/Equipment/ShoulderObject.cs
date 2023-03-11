using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Shoulder Object", menuName = "Inventory System/Items/Equipment/Shoulder")]
public class ShoulderObject : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Shoulder;
    }
}
