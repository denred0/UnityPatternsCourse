using System;
using UnityEngine;

[Serializable]
public class PlayerConfig
{
    [SerializeField, Range(0, 50)] public int InitialHealth;
    [SerializeField, Range(0, 10)] public int InitialLevel;
    [SerializeField, Range(50, 100)] public int NextLevelExperience; 
}
