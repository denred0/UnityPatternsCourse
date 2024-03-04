using System;
using UnityEngine;

public class PlayerLevel
{
    public PlayerLevel(int initialLevel)
    {
        InitialLevel = Value = initialLevel;
        Debug.Log($"Current level: {Value}");
    }

    public int InitialLevel { get; }

    public int Value { get; private set; }

    public void Add(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        Value += value;

        Debug.Log($"Current level: {Value}");
    }

    public void ResetLevel()
    {
        Value = InitialLevel;
    }
}
