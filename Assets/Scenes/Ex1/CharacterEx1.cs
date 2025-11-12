using UnityEngine;
[RequireComponent (typeof(Rigidbody2D))]
[RequireComponent (typeof(MoveBehaviourEx1))]
[RequireComponent (typeof(JumpBehaviourEx1))]
public class CharacterEx1 : MonoBehaviour
{
    [SerializeField] protected MoveBehaviourEx1 _mb;
    [SerializeField] protected JumpBehaviourEx1 _jb;
    void Awake()
    {
        _mb = GetComponent<MoveBehaviourEx1>();
        _jb = GetComponent<JumpBehaviourEx1>();
    }
}
