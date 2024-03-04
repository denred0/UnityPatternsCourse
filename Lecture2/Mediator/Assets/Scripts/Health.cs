using System;
using UnityEngine;

public class Health
{
    public Health(int maxHealth)
    {
        MaxHealth = Value = maxHealth;
        Debug.Log($"Current health: {Value}");
    }

    public int MaxHealth { get; }

    public int Value { get; private set; }

    public void Add(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        Value += value;

        if (Value > MaxHealth)
            Value = MaxHealth;

        Debug.Log($"Current health: {Value}");
    }

    public void Reduce(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        Value -= value;

        if (Value <= 0)
        {
            Value = 0;
        }

        Debug.Log($"Current health: {Value}");
    }

    public void ResetHealth()
    {
        Value = MaxHealth;
    }
}
