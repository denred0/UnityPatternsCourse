using System;
using UnityEngine;

[Serializable]
public class DamagerConfig 
{
    [SerializeField, Range(1, 10)] public int DamageAmount;
}
