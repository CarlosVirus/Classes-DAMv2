using UnityEngine;
public abstract class Weapon : ScriptableObject
{
    [SerializeField] public int _damage;
    [SerializeField] public float _cooldown;
    public abstract void Attack();
}
