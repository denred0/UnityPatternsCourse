using System;

public class StateMachineData {
    public float XVelocity;
    public float YVelocity;
    public float Energy;
    public float EnergyDecreasingAmount;

    private float _speed;

    public float Speed {
        get => _speed;
        set {

            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(_speed));

            _speed = value;
        }
    }

}
