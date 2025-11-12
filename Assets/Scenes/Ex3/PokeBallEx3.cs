using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PokeBallEx3 : ItemEx3
{
    public override void Use(GameObject t)
    {
        base.Use(t);
        Debug.Log($"you throw a {gameObject.name}");
    }
}
