using UnityEngine.InputSystem;
public class MovementWithLegsState : GroundedState
{

    public MovementWithLegsState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
    }

    public override void Enter()
    {
        base.Enter();

        View.StartMovementWithLegs();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopMovementWithLegs();
    }

    public override void Update()
    {
        base.Update();

        if (IsGroundTouch == false)
            return;

        if (IsHorizontalInputZero)
            StateSwitcher.SwitchState<IdlingState>();
        else
        {
            if (Data.IsFastRunKeyPressed)
                StateSwitcher.SwitchState<FastRunningState>();
            else
            {
                if (Data.IsRunKeyPressed)
                    StateSwitcher.SwitchState<RunningState>();
                else
                    StateSwitcher.SwitchState<WalkingState>();
            }
        }
    }

    protected override void AddInputActionsCallback()
    {
        base.AddInputActionsCallback();

        Input.Movement.Run.performed += OnRunKeyPressed;
        Input.Movement.Run.canceled += OnRunKeyReleased;

        Input.Movement.FastRun.performed += OnFastRunKeyPressed;
        Input.Movement.FastRun.canceled += OnFastRunKeyReleased;
    }

    protected override void RemoveInputActionsCallback()
    {
        base.RemoveInputActionsCallback();

        Input.Movement.Run.performed -= OnRunKeyPressed;
        Input.Movement.Run.canceled -= OnRunKeyReleased;

        Input.Movement.FastRun.performed -= OnFastRunKeyPressed;
        Input.Movement.FastRun.canceled -= OnFastRunKeyReleased;
    }

    private void OnRunKeyPressed(InputAction.CallbackContext obj)
    {
        Data.IsRunKeyPressed = true;
    }

    private void OnRunKeyReleased(InputAction.CallbackContext obj)
    {
        Data.IsRunKeyPressed = false;
    }
    private void OnFastRunKeyPressed(InputAction.CallbackContext obj)
    {
        Data.IsFastRunKeyPressed = true;
    }

    private void OnFastRunKeyReleased(InputAction.CallbackContext obj)
    {
        Data.IsFastRunKeyPressed = false;
    }

}
