using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    void OnEnable()
    {
        GetComponent<PlayerManager>().onRampageAction += IncreaseDamage;
    }

    void OnDisable()
    {
        GetComponent<PlayerManager>().onRampageAction -= IncreaseDamage;
    }

    void IncreaseDamage()
    {
        //increase damage
    }
}
