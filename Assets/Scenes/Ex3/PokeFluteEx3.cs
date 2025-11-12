using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PokeFluteEx3 : ItemEx3
{
    public override void Use(GameObject t)
    {
        base.Use(t);
        Debug.Log(t.name + $" is awake");
    }
}
