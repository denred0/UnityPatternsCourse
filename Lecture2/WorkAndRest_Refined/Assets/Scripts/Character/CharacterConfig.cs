using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField, Range(0, 100)] private float _energy;
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private RestingStateConfig _restingStateConfig;
    [SerializeField] private WorkingStateConfig _workingStateConfig;

    public Vector3 InitialPoint => RestingStateConfig.RestingPosition.transform.position;

    public float Energy => _energy;

    public RunningStateConfig RunningStateConfig => _runningStateConfig;

    public RestingStateConfig RestingStateConfig => _restingStateConfig;

    public WorkingStateConfig WorkingStateConfig => _workingStateConfig;
}
