using System;
using UnityEngine;

[Serializable]
public class RestingStateConfig
{
    [SerializeField] public Transform RestingPosition;
    [SerializeField, Range(0.1f, 1.0f)] public float EnergyIncreasingAmount;
    [field: SerializeField, Range(0, 5)] public float RestingRange { get; private set; }
}
