using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Wrist Object", menuName = "Inventory System/Items/Equipment/Wrist")]
public class WristObject : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Wrist;
    }
}
