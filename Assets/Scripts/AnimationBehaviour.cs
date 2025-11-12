using UnityEngine;

public class AnimationBehaviour : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _sr;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
    }
    public void RunAnimation(Vector2 direction)
    {
        if (direction.x < 0)
            _sr.flipX = true;
        else if(direction.x > 0)
            _sr.flipX = false;
        _animator.SetFloat("Velocity", direction.magnitude);
    }

}
