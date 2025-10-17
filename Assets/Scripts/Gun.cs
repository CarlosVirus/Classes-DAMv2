using System.Collections;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] protected int maxBullets, currentBullets;
    [SerializeField] protected float timeBetweenShots;
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected Transform ShootingPoint;
    protected bool canShoot = true;
    public abstract void Shoot();
    protected IEnumerator ShootCoroutine()
    {
        yield return new WaitForSeconds(timeBetweenShots);
        canShoot = true;
    }
}
