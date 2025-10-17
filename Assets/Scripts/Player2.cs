using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Player2 : MonoBehaviour, InputSystem_Actions.IPlayerActions
{
    [SerializeField] private GameObject bullet;
    private InputSystem_Actions inputActions;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Transform _shootPoint;
    public Stack<GameObject> bulletPool = new Stack<GameObject>();
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        inputActions = new InputSystem_Actions();
        inputActions.Player.SetCallbacks(this);
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        Attack();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        _rb.linearVelocity= context.ReadValue<Vector2>(); 
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        /*if (context.performed)
        {
            Vector3 clickPoint = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
            RaycastHit2D hit = Physics2D.Raycast(clickPoint, Vector3.forward, 12f);
            if (hit)
            {
                Debug.Log(hit.collider.gameObject.name);
                AudioClip clip = null;
                foreach (var kvp in AudioManager.Instance.clipList)
                {
                    if (AudioManager.Instance.clipList.ContainsKey(AudioClips.Yamete))
                        clip = kvp.Value;
                }
                AudioSource aSource = GetComponent<AudioSource>();
                if (clip != null)
                {
                    aSource.clip = clip;
                }
                aSource.Play();
            }
        }*/
       //Debug.Log( context.ReadValue<Vector2>());
    }

    public void Attack()
    {
        if(bulletPool.Count>0)
        {
            GameObject bullet = bulletPool.Pop();
            bullet.SetActive(true);
            bullet.transform.position = _shootPoint.position;
            bullet.transform.rotation = Quaternion.identity;
            bullet.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 1f);
        }
        else
        {
            GameObject newBullet = Instantiate(bullet, _shootPoint.position, Quaternion.identity);
            newBullet.GetComponent<Bullet>().bulletPool = bulletPool;
            bullet.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 1f);
        }
    }
}
