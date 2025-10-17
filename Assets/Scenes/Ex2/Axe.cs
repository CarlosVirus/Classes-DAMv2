using UnityEngine;

public class Axe : MonoBehaviour
{
    [SerializeField] private int damage;
    private bool _canAttack = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.TryGetComponent<IDamageableEx2>(out IDamageableEx2 iDmg)&& _canAttack)
        {
            iDmg.Hurt(damage);
            _canAttack = false;
            Invoke("CanAttackAgain", 2f);
        }
    }
    public void CanAttackAgain()
    {
        _canAttack=true;   
    }
}
