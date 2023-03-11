using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Consumable Object", menuName = "Inventory System/Items/Consumable")]
public class ConsObject : ItemObject
{
    public int restoreHealthValue;
    public int restoreManathValue;
    public int restoreEnduranceValue;
    public float addStrenght;
    public float addAttackSpeed;
    private void Awake()
    {
        type = ItemType.Consumable;
    }
}
