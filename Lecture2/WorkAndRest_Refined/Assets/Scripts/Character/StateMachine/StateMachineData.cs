using System;
using UnityEngine;

public class StateMachineData
{
    public float XDirection;
    public float ZDirection;

    public Vector3 CurrentActionPoint;

    private float _speed;
    private float _energy;

    public float Energy
    {
        get => _energy;
        set
        {
            if (value < 0)
                value = 0;

            _energy = value;
        }
    }

    public float Speed
    {
        get => _speed;
        set
        {

            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(_speed));

            _speed = value;
        }
    }

}
