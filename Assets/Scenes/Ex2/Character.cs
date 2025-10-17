using UnityEngine;

public class Character : MonoBehaviour, IDamageableEx2
{
    [SerializeField] protected int HP;
    public void Hurt(int dmg)
    {
        Debug.Log("AY");
        HP-= dmg;
    }
}
