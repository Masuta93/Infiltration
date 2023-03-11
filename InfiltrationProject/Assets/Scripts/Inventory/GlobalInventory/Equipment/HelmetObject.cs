using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "New Helmet Object", menuName = "Inventory System/Items/Equipment/Helmet")]
public class HelmetObject : EquipmentObject
{
    private void Awake()
    {
        equipmentType = EquipmentType.Helmet;
    }
}
