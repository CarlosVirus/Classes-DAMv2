using UnityEngine;
using System.Collections.Generic;

public class InventoryEx3 : MonoBehaviour
{
    public List<ItemEx3> items;
    public void Use(int item, GameObject target)
    {
        items[item].Use(target);
    }
}
