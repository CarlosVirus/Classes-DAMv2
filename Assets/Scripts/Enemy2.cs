using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] private Transform[] _enemyLimitPositionsX;
    private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    [SerializeField] private float _offset;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = new Vector3(_speed, 0);
        _enemyLimitPositionsX[0] = GameObject.Find("EnemyLimitPositionNegX").transform;
        _enemyLimitPositionsX[1] = GameObject.Find("EnemyLimitPositionPosX").transform;
    }
    private void Update()
    {
        if (transform.position.x <= _enemyLimitPositionsX[1].position.x && _speed > 0)
        {
            OnMove();
        }
        else if (transform.position.x >= _enemyLimitPositionsX[0].position.x && _speed < 0)
        {
            OnMove();
        }
        else if(_speed > 0)
        {
            Return();
        }
        else if (_speed < 0)
        {
            Return();
            transform.position -= new Vector3(0, _offset, 0);
        }

    }
    public void OnMove()
    {
        _rb.linearVelocityX = _speed;
    }
    public void Return()
    {
        _speed *= -1;
        _rb.linearVelocityX = _speed;
    }
}
