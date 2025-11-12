using UnityEngine;

public class FlyingBomb : EnemyEx4, IFlying, IExplosive
{
    public void Fly()
    {
        Debug.Log("Flying free");
    }
    public void Explode()
    {
        Debug.Log("Hace pum y ya está aquí la guerra");
    }
}
