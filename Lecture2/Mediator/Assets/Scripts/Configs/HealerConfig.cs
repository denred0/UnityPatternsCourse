using System;
using UnityEngine;

[Serializable]
public class HealerConfig
{
    [SerializeField, Range(1, 10)] public int HealAmount;
}
