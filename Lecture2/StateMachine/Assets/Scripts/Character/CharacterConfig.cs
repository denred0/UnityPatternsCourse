using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private WalkingStateConfig _walkingStateConfig;
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private FastRunningStateConfig _fastRunningStateConfig;
    [SerializeField] private AirbornStateConfig _airbornStateConfig;

    public WalkingStateConfig WalkingStateConfig => _walkingStateConfig;
    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public FastRunningStateConfig FastRunningStateConfig => _fastRunningStateConfig;
    public AirbornStateConfig AirbornStateConfig => _airbornStateConfig;
}
