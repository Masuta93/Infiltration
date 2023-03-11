using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Feet Object", menuName = "Inventory System/Items/Equipment/Feet")]
public class FeetObject : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Feet;
    }
}
