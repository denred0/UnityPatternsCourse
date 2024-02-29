using UnityEngine;

public abstract class MovementState : BaseState
{
    private readonly Character _character;

    private float _minDistanceToPoint = 0.1f;
    private Vector3 _movementDirection;

    public MovementState(IStateSwitcher stateSwitcher, StateMachineData data, Character character, StatesPoints statesPoints) : base(stateSwitcher, data, character, statesPoints) => _character = character;
    

    private CharacterController Controller => _character.Controller;

    public override void Enter()
    {
        base.Enter();

        _movementDirection = GetNormalizedMovementDirection(Data.CurrentActionPoint);
        SetCharacterMovementDirection(_movementDirection);

        View.StartMovement();
    }

    public override void Exit()
    {
        base.Exit();
        View.StopMovement();
    }

    public override void Update()
    {
        base.Update();

        MoveCharacterToTargetPoint();

        if (Vector3.Distance(_character.transform.position, Data.CurrentActionPoint) < _minDistanceToPoint)
           OnReachTarget();
    }

    protected abstract void OnReachTarget();

    private void MoveCharacterToTargetPoint() {
        Vector3 velocity = GetConvertedDirection() * Data.Speed;
        Controller.Move(velocity * Time.deltaTime);

        if (_movementDirection != Vector3.zero)
            _character.transform.right = _movementDirection;
    }

    private Vector3 GetConvertedDirection() => new Vector3(Data.XDirection, 0, Data.ZDirection);

    private Vector3 GetNormalizedMovementDirection(Vector3 targetPosition) => (targetPosition - _character.transform.position).normalized;

    private void SetCharacterMovementDirection(Vector3 movementDirection)
    {
        Data.XDirection = movementDirection.x;
        Data.ZDirection = movementDirection.z;
    }

}
