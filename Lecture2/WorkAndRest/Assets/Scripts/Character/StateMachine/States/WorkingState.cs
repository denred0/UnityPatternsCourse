using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingState : MovementState
{ 
    private CharacterConfig _characterConfig;
    private WorkingStateConfig _workingStateConfig;

    public WorkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
        _characterConfig = character.Config;
        _workingStateConfig = character.Config.WorkingStateConfig;
    }

    public override void Enter()
    {
        base.Enter();

        View.StartWorking();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopWorking();
    }

    public override void Update()
    {
        base.Update();

        Data.Energy -= _workingStateConfig.WorkingDecreasingAmount; 
        Debug.Log($"Energy: {Data.Energy}");

        if (Data.Energy <= 0)
        {
            Data.Energy = 0;
            StateSwitcher.SwitchState<RunningState>();
        }
    }
}
