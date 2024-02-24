public class BaseMovingState : GroundedState
{

    private const float KeyPressed = 1;

    public BaseMovingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
    }

    public bool IsRunKeyPressed => Input.Movement.Run.ReadValue<float>() == KeyPressed;
    public bool IsFastRunKeyPressed => Input.Movement.FastRun.ReadValue<float>() == KeyPressed;

    public override void Enter()
    {
        base.Enter();

        View.StartBaseMoving();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopBaseMoving();
    }

    public override void Update()
    {
        base.Update();

        if (IsGroundTouch == false)
            return;

        if (IsHorizontalInputZero)
            StateSwitcher.SwitchState<IdlingState>();

    }

}
