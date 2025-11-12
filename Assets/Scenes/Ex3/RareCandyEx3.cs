using UnityEngine;

public class RareCandyEx3 : ItemEx3
{
    public override void Use(GameObject t)
    {
        base.Use(t);
        Debug.Log(t.name + $" Leveled Up");
    }
}
