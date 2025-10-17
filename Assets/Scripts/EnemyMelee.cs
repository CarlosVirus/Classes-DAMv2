using System.Collections;
using UnityEngine;

public class EnemyMelee : Enemy
{
    [SerializeField] private Transform hand;
    private int iterations = 30;
    private float animationTime = 5f;
    private float scaling = 1f;
    private Vector3 force = new Vector3(1, 1, 1);
    private float forceModule = 3f;
    public override void Attack()
    {
        GameObject punch = Instantiate(_prefab, hand.transform.position, Quaternion.identity);
        StartCoroutine(punchUp(punch));
    }
    private IEnumerator punchUp(GameObject punch)
    {
        for(int i=0; i<iterations; i++)
        {
            yield return new WaitForSeconds(animationTime / iterations);
            punch.transform.localScale = punch.transform.localScale + new Vector3(1,1,1) *scaling / iterations;
            punch.GetComponent<Rigidbody2D>().AddForce(force * forceModule);
        }
    }
}
