using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Asteroid : MonoBehaviour
{
    [SerializeField] Vector3 speed;

    IObjectPool<Asteroid> asteroidPool;

    void Update()
    {
        transform.position += speed * Time.deltaTime;
    }

    public void SetPool(IObjectPool<Asteroid> pool)
    {
        asteroidPool = pool;
    }

    void OnBecameInvisible()
    {
        asteroidPool.Release(this);
    }
}
