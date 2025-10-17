using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float timeToWait = 0;
    private float timeBetweenEnemies = 1f;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float LeftLimit, RightLimit;
    public Stack<GameObject> EnemiesStack = new Stack<GameObject>();
    void Update()
    {
        if(Time.time >= timeToWait)
        {
            if (EnemiesStack.Count == 0)
            {
                InstantiateEnemies();
            }
            else
            {
                Pop();
            }
            timeToWait = Time.time + timeBetweenEnemies;
        }
    }
    public void Push(GameObject go)
    {
        EnemiesStack.Push(go);
        go.SetActive(false);
    }
    public GameObject Pop()
    {
        GameObject go = EnemiesStack.Pop();
        go.SetActive(true);
        go.transform.position = transform.position;
        go.GetComponent<Rigidbody2D>().linearVelocityX = 5f;
        return go;
    }
    public void InstantiateEnemies()
    {
        GameObject enem = Instantiate(enemy, transform.position, Quaternion.identity);
        enem.GetComponent<Enemigo>()._enemyLimitPositionXNegative = LeftLimit;
        enem.GetComponent<Enemigo>()._enemyLimitPositionXPositive = RightLimit;
        enem.GetComponent<Enemigo>().spawner = this;
    }

}
