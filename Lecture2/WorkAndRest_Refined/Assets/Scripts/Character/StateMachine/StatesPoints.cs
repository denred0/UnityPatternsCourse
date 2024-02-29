using System.Collections.Generic;
using UnityEngine;
using System;

public class StatesPoints
{
    private CharacterConfig _config;
    private Dictionary<Vector3, Type> _statesPoints = new Dictionary<Vector3, Type>();

    public StatesPoints(CharacterConfig config)
    {
        _config = config;

        _statesPoints.Add(_config.WorkingStateConfig.WorkingPosition.transform.position, typeof(WorkingState));
        _statesPoints.Add(_config.RestingStateConfig.RestingPosition.transform.position, typeof(RestingState));
    }

    public Type GetStateType(Vector3 targetPosition) => _statesPoints[targetPosition];
}
