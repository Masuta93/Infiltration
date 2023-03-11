using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Trinket Object", menuName = "Inventory System/Items/Equipment/Trinket")]
public class Trinket : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Trinket;
    }
}
