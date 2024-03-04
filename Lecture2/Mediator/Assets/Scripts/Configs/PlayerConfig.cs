using System;
using UnityEngine;

[Serializable]
public class PlayerConfig
{
    [SerializeField, Range(0, 50)] private int _initialHealth;
    [SerializeField, Range(0, 10)] private int _initialLevel;
    [SerializeField, Range(50, 100)] private int _nextLevelExperience;

    public int InitialHealth => _initialHealth;

    public int InitialLevel => _initialLevel;

    public int NextLevelExperience => _nextLevelExperience;

}
