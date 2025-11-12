using UnityEngine;

public class EnemyEx1 : CharacterEx1
{
    private Vector2 _direction = new Vector2(1, 0);
    private void Start()
    {
        float random = Random.Range(1.5f, 3f);
        Invoke("RandomMove", random);
        float random2 = Random.Range(1.5f, 3f);
        Invoke("RandomJump", random2);
        if (random2 < 2.25f)
            _direction *= -1;
        _mb.Move(_direction);
    }
    public void RandomMove()
    {
        _direction *= -1;
        _mb.Move(_direction);
        float random = Random.Range(1.5f, 3f);
        Invoke("RandomMove", random);
    }
    public void RandomJump()
    {
        _jb.Jump();
        float random = Random.Range(1.5f, 3f);
        Invoke("RandomJump", random);
    }
}
