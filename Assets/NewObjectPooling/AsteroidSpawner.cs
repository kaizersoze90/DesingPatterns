using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] Asteroid asteroidPrefab;

    IObjectPool<Asteroid> asteroidPool;

    void Awake()
    {
        asteroidPool = new ObjectPool<Asteroid>
            (
                CreateAsteroid,
                ActionOnGet,
                ActionOnRelease,
                ActionOnDestroy,
                maxSize: 10
            );
    }

    Asteroid CreateAsteroid()
    {
        Asteroid asteroid = Instantiate(asteroidPrefab, transform);
        asteroid.SetPool(asteroidPool);
        return asteroid;
    }

    void ActionOnGet(Asteroid asteroid)
    {
        asteroid.transform.position = transform.position;
        asteroid.gameObject.SetActive(true);
    }

    void ActionOnRelease(Asteroid asteroid)
    {
        asteroid.gameObject.SetActive(false);
    }

    void ActionOnDestroy(Asteroid asteroid)
    {
        Destroy(asteroid.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            asteroidPool.Get();
        }
    }
}
