using UnityEngine;

public class PotionEx3 : ItemEx3
{
    [SerializeField] private int _healAmount;
    public override void Use(GameObject t)
    {
        base.Use(t);
        Debug.Log(t.name + $" Restored {_healAmount} HP");
    }
}
