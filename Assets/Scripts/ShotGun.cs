using System.Collections;
using UnityEngine;

public class ShotGun : Gun
{
    [SerializeField] private int bulletsPerShot;
    public override void Shoot()
    {
        if(canShoot && currentBullets>0)
        {
            canShoot = false;
            StartCoroutine(ShootCoroutine());
            for (int i = 0; i < bulletsPerShot; i++)
            {
                float angle = Random.Range(-15f, 15f);
                GameObject currentBullet = Instantiate(bullet, ShootingPoint.position, Quaternion.identity);
                currentBullet.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
            }
        }
    }
}
