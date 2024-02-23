using UnityEngine.InputSystem;

public class GroundedState : MovementState
{
   // protected bool IsRunKeyPressed;
    private readonly GroundChecker _groundChecker;
    public GroundedState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) => _groundChecker = character.GroundChecker;

    public bool IsGroundTouch => _groundChecker.IsTouch;

    public override void Enter()
    {
        base.Enter();

        View.StartGrounded();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopGrounded();
    }

    public override void Update()
    {
        base.Update();

       // Debug.Log(_groundChecker.IsTouch);

        if (IsGroundTouch == false)
            StateSwitcher.SwitchState<FallingState>();
    }

    protected override void AddInputActionsCallback()
    {
        base.AddInputActionsCallback();

        Input.Movement.Jump.started += OnJumpKeyPressed;

    }

    protected override void RemoveInputActionsCallback()
    {
        base.RemoveInputActionsCallback();

        Input.Movement.Jump.started -= OnJumpKeyPressed;
    }

    private void OnJumpKeyPressed(InputAction.CallbackContext context)
    {
        StateSwitcher.SwitchState<JumpingState>();
    }
}
