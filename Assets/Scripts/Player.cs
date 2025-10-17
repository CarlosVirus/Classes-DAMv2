using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;
    public void Attack()
    {
        _weapon.Attack();
    }
}
