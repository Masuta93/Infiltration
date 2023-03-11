using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Hand Object", menuName = "Inventory System/Items/Equipment/Hand")]
public class HandObject : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Hands;
    }
}
