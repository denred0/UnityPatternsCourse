using UnityEngine;

public abstract class MovementState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly StateMachineData Data;
    private readonly Character _character;
    private CharacterConfig _characterConfig;

    protected MovementState(IStateSwitcher stateSwitcher, StateMachineData data, Character character)
    {
        StateSwitcher = stateSwitcher;
        _character = character;

        Data = data;
    }

    protected CharacterVIew View => _character.View;
    private CharacterController Controller => _character.Controller;

    private Quaternion TurnRight => new Quaternion(0, 0, 0, 0);

    private Quaternion TurnLeft => Quaternion.Euler(0, 180, 0);

    public virtual void Enter()
    {
        Debug.Log(GetType());
        AddInputActionsCallback();

        View.StartMovement();
    }

    public virtual void Exit()
    {
        RemoveInputActionsCallback();

        View.StopMovement();
    }

    public virtual void Update()
    {
        Vector3 velocity = GetConvertedVelocity();
        Controller.Move(velocity * Time.deltaTime);
        _character.transform.rotation = GetRotationFrom(velocity);
    }

    protected virtual void AddInputActionsCallback() { }

    protected virtual void RemoveInputActionsCallback() { }

    private Quaternion GetRotationFrom(Vector3 velocity)
    {
        if (velocity.x > 0)
            return TurnRight;

        if (velocity.x < 0)
            return TurnLeft;

        return _character.transform.rotation;
    }

    private Vector3 GetConvertedVelocity() => new Vector3(Data.XVelocity, Data.YVelocity, 0);
}
