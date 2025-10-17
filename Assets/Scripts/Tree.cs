using UnityEngine;
using System.Collections.Generic;

public class Tree : MonoBehaviour, IDamageable
{
    [SerializeField] private List<GameObject> loot;
    private int maxLoot = 3;
    public void GetHurt(int damage)
    {
        int random = Random.Range(0, loot.Count);
        if(maxLoot>0)
        {
            Instantiate(loot[random], transform.position, Quaternion.identity);
            maxLoot--;
        }
    }
}
