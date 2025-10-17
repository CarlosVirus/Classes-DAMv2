using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "Gun", menuName = "ScriptableObjects/Weapons/Gun")]
public class Gun2 : Weapon
{
    public override void Attack()
    {
        Debug.Log("pim piu piu");
    }
}
