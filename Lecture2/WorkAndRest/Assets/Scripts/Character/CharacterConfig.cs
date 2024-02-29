using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField, Range(0, 100)] private float _energy;
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private RestingStateConfig _restingStateConfig;
    [SerializeField] private WorkingStateConfig _workingStateConfig;
    [SerializeField] private Dictionary<SS, Transform> _statesAndPoints;

    private enum SS
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 100,
        OutlierReading = 200
    }

    public float Energy => _energy;

    public RunningStateConfig RunningStateConfig => _runningStateConfig;

    public RestingStateConfig RestingStateConfig => _restingStateConfig;

    public WorkingStateConfig WorkingStateConfig => _workingStateConfig;
}
