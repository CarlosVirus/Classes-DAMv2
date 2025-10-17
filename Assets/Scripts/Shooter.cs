using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private List<Gun> WeaponInventory;
    [SerializeField] private Gun currentWeapon;

    private void Awake()
    {
        currentWeapon = WeaponInventory[Random.Range(0, WeaponInventory.Count)];
    }
    public void Shoot()
    {
        currentWeapon.Shoot();
    }
}
