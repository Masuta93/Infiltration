using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Waist Object", menuName = "Inventory System/Items/Equipment/Waist")]
public class WaistObject : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Waist;
    }
}
