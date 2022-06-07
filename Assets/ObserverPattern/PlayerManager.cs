using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public event Action onRampageAction;

    void ProcessFullRage()
    {
        //when rage is full
        if (onRampageAction != null)
        {
            onRampageAction();
        }
    }
}
