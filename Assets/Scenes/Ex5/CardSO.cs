using UnityEngine;
public abstract class CardSO : ScriptableObject
{
    public string Name;
    public string Description;
    public int HP;
    public int Damage;
    public Sprite Image;
    public abstract void Action();
}
