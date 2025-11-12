using UnityEngine;

public abstract class ItemEx3 : MonoBehaviour
{
    [SerializeField] protected string _name;
    [SerializeField] protected int _amount;
    [SerializeField] protected string _description;
    public virtual void Use(GameObject target)
    {
        _amount--;
    }
}
