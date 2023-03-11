using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Necklace Object", menuName = "Inventory System/Items/Equipment/Necklace")]
public class Necklace : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Necklace;
    }
}
