using UnityEngine;
using System.Collections.Generic;
public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    public Stack<GameObject> bulletPool;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bulletPool.Push(gameObject);
        _rb.linearVelocity = Vector2.zero;
        gameObject.SetActive(false);
    }
}
