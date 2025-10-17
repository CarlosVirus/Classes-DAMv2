using UnityEngine;

public class Pistol : Gun
{
    public override void Shoot()
    {
        if (canShoot && currentBullets > 0)
        {
            canShoot = false;
            StartCoroutine(ShootCoroutine());
            GameObject currentBullet = Instantiate(bullet, ShootingPoint.position, Quaternion.identity);
            currentBullet.GetComponent<Rigidbody2D>().linearVelocity = currentBullet.transform.right;
        }
    }
}
