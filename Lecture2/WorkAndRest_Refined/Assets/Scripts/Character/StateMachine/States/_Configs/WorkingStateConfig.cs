using System;
using UnityEngine;

[Serializable]
public class WorkingStateConfig
{
    [SerializeField] public Transform WorkingPosition;
    [SerializeField, Range(0.1f, 1.0f)] public float EnergyDecreasingAmount;

    [field: SerializeField, Range(0, 5)] public float WorkingRange { get; private set; }
}
