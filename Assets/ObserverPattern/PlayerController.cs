using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] UnityEvent onRampage;

    void ProcessFullRage()
    {
        //when rage is full
        onRampage.Invoke();
    }
}
