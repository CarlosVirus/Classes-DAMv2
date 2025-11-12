using UnityEngine;
public abstract class Weapon : ScriptableObject
{
    public int Damage;
    public float Cooldown;
    public abstract void Attack();
}
