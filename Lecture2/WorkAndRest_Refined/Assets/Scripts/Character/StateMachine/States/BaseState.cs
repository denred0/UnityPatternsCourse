using UnityEngine;

public abstract class BaseState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly StateMachineData Data;
    protected readonly StatesPoints StatesPoints;

    private readonly Character _character;

    protected BaseState(IStateSwitcher stateSwitcher, StateMachineData data, Character character, StatesPoints statesPoints)
    {
        StateSwitcher = stateSwitcher;
        _character = character;
        StatesPoints = statesPoints;

        Data = data;
        Data.CurrentActionPoint = _character.Config.InitialPoint;
    }

    protected CharacterVIew View => _character.View;

    public virtual void Enter()
    {
        Debug.Log(GetType());
        AddInputActionsCallback();

        View.StartBase();
    }

    public virtual void Exit()
    {
        RemoveInputActionsCallback();

        View.StopBase();
    }

    public virtual void Update()
    {
       
    }

    protected virtual void AddInputActionsCallback() { }

    protected virtual void RemoveInputActionsCallback() { }

}
