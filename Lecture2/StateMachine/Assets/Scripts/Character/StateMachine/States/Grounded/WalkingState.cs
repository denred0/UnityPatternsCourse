public class WalkingState : MovementWithLegsState
{
    private WalkingStateConfig _config;
    public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) => _config = character.Config.WalkingStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartWalking();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopWalking();
    }

}
