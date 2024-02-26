using UnityEngine;

public class RunningState : MovementState
{
    private RunningStateConfig _runningStateConfig;
    private RestingStateConfig _restingStateConfig;
    private WorkingStateConfig _workingStateConfig;
    private CharacterConfig _characterConfig;
    private Character _character;

    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
        _character = character;
        _runningStateConfig = character.Config.RunningStateConfig;
        _restingStateConfig = character.Config.RestingStateConfig;
        _workingStateConfig = character.Config.WorkingStateConfig;
        _characterConfig = character.Config;
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _runningStateConfig.Speed;
        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (Data.Energy <= 0)
        {
            Vector3 movementVelocity = GetVelocity(_restingStateConfig.RestingPosition.position);
            SetCharacterVelocity(movementVelocity);

            if (IsReachTargetPosition(_restingStateConfig.RestingPosition.position, _restingStateConfig.RestingRange))
            {
                StopCharacterMovement();
                StateSwitcher.SwitchState<RestingState>();
            }
        }

        if (Data.Energy >= _characterConfig.Energy)
        {
            Vector3 movementVelocity = GetVelocity(_workingStateConfig.WorkingPosition.position);
            SetCharacterVelocity(movementVelocity);

            if (IsReachTargetPosition(_workingStateConfig.WorkingPosition.position, _workingStateConfig.WorkingRange))
            {
                StopCharacterMovement();
                StateSwitcher.SwitchState<WorkingState>();
            }
        }
    }

    private Vector3 GetVelocity(Vector3 targetPosition) => (targetPosition - _character.transform.position).normalized * Data.Speed;

    private float GetTargetPointDistance(Vector3 targetPosition) => Vector3.Distance(_character.transform.position, targetPosition);

    private void StopCharacterMovement()
    {
        Data.XVelocity = 0;
        Data.YVelocity = 0;
    }

    private void SetCharacterVelocity(Vector3 movementVelocity)
    {
        Data.XVelocity = movementVelocity.x;
        Data.YVelocity = movementVelocity.z;
    }

    private bool IsReachTargetPosition(Vector3 targetPosition, float rangePosition)
    {
        float targetPointDistance = GetTargetPointDistance(targetPosition);
        return targetPointDistance < rangePosition;
    }
}
