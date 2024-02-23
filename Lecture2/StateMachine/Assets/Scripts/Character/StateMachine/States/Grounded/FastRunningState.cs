public class FastRunningState : MovementWithLegsState
{
    private FastRunningStateConfig _config;

    public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) => _config = character.Config.FastRunningStateConfig;
    

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartFastRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopFastRunning();
    }


}
