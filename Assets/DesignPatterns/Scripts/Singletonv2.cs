using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singletonv2 : MonoBehaviour
{
    [SerializeField] GameObject singleObject;

    static bool hasSpawned;

    void Awake()
    {
        if (hasSpawned) { return; }

        SpawnPersistentObject();

        hasSpawned = true;
    }

    void SpawnPersistentObject()
    {
        GameObject persistentObject = Instantiate(singleObject);

        DontDestroyOnLoad(gameObject);
    }
}
