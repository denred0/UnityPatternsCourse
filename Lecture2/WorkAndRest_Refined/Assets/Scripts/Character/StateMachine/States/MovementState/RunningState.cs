using System;

public class RunningState : MovementState
{
    private RunningStateConfig _runningStateConfig;

    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character, StatesPoints statesPoints) : base(stateSwitcher, data, character, statesPoints)
    {
        _runningStateConfig = character.Config.RunningStateConfig;
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

    protected override void OnReachTarget()
    {
        Type stateType = StatesPoints.GetStateType(Data.CurrentActionPoint);
        StateSwitcher.SwitchState(stateType);
    }

}
