using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] int pointsPerLevel = 200;
    [SerializeField] UnityEvent onLevelUp;
    int experiencePoints = 0;

    public event Action onLevelUpAction;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(.2f);
            GainExperience(10);
        }
    }

    public void GainExperience(int points)
    {
        int currentLevel = GetLevel();
        experiencePoints += points;
        if (currentLevel < GetLevel())
        {
            onLevelUp.Invoke();
            if (onLevelUpAction != null)
            {
                onLevelUpAction();
            }
        }
    }

    public int GetExperience()
    {
        return experiencePoints;
    }

    public int GetLevel()
    {
        return experiencePoints / pointsPerLevel;
    }
}