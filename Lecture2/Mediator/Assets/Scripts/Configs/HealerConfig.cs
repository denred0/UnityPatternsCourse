using System;
using UnityEngine;

[Serializable]
public class HealerConfig
{
    [SerializeField, Range(1, 10)] private int _healAmount;

    public int HealAmount => _healAmount;
}
