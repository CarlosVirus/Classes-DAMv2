using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class Enemigo : MonoBehaviour
{
    //[SerializeField] private GameObject _enemyMinPosX, _enemyMinPosY;
    [SerializeField] private Rigidbody2D _rb;
    public float _enemyLimitPositionXPositive = 5 ;
    public float _enemyLimitPositionXNegative = -5;
    [SerializeField] private float _enemyLimitPositionY = 5 ;
    [SerializeField] private Vector2 actualPosition;
    public Spawner spawner;
    void Start()
    {
        OnMove();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
            GameOver();
        else if(collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
            //Destroy(gameObject);
            spawner.Push(gameObject);
        }
    }
    public void GameOver()
    {
        Debug.Log("GAmeOver");
    }

    void Update()
    {
        if (transform.position.x <= _enemyLimitPositionXPositive && _rb.linearVelocityX>0)
        {
            _rb.linearVelocityX = 5;
        }
        else if(transform.position.x > _enemyLimitPositionXPositive && _rb.linearVelocityX > 0)
        {
            transform.position = new Vector3(_enemyLimitPositionXPositive, transform.position.y, transform.position.z);
            _rb.linearVelocityX = -5;
        }
        else if (transform.position.x >= _enemyLimitPositionXNegative && _rb.linearVelocityX < 0)
        {
            _rb.linearVelocityX = -5;
        }
        else if (transform.position.x < _enemyLimitPositionXNegative && _rb.linearVelocityX < 0)
        {
            transform.position = new Vector3(_enemyLimitPositionXNegative, transform.position.y, transform.position.z);
            _rb.linearVelocityX = 5;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f);
        }
    }
    public void OnMove()
    {
        _rb.linearVelocity = new Vector3(1,0,0)*5;
    }
}
