using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable, IKillable
{
    [SerializeField] protected GameObject _prefab;
    [SerializeField] protected int _healthPoints;
    public abstract void Attack();
    public void Die()
    {
        Destroy(gameObject);
    }
    public void GetHurt(int damage)
    {
        _healthPoints -= damage;
        if (_healthPoints <= 0)
            Die();
    }
}
