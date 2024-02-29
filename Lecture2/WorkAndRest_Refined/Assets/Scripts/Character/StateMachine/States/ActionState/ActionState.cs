using UnityEngine;

public abstract class ActionState : BaseState
{
    private readonly Character _character;

    private float _minDistanceToPoint = 0.1f;

    protected ActionState(IStateSwitcher stateSwitcher, StateMachineData data, Character character, StatesPoints statesPoints) : base(stateSwitcher, data, character, statesPoints) => _character = character;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = 0;

        View.StartAction();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopAction();
    }

    public override void Update()
    {
        base.Update();

        if (Vector3.Distance(_character.transform.position, Data.CurrentActionPoint) > _minDistanceToPoint)
            StateSwitcher.SwitchState(typeof(RunningState));
    }

}
