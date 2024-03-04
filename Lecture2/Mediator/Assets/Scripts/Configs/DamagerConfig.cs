using System;
using UnityEngine;

[Serializable]
public class DamagerConfig 
{
    [SerializeField, Range(1, 10)] private int _damageAmount;

    public int DamageAmount => _damageAmount;
}
