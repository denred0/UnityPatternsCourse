using System.Collections.Generic;
using UnityEngine;
using System;

public class RestingState : MovementState
{
    private CharacterConfig _characterConfig;
    private RestingStateConfig _restingStateConfig;


    public RestingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
        _characterConfig = character.Config;
        _restingStateConfig = character.Config.RestingStateConfig;
    }


    public override void Enter()
    {
        base.Enter();

        View.StartResting();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopResting();
    }

    public override void Update()
    {
        base.Update();

        Data.Energy += _restingStateConfig.EnergyIncreasingAmount;
        Debug.Log($"Energy: {Data.Energy}");

        if (Data.Energy >= _characterConfig.Energy)
        { 
            Data.Energy = _characterConfig.Energy;

            Dictionary<Vector3, Type> _statesPoints = new Dictionary<Vector3, Type>();
            _statesPoints.Add(new Vector3(0, 0, 0), typeof(RunningState));
            Type stateName = _statesPoints[new Vector3(0, 0, 0)];


            StateSwitcher.SwitchState<RunningState>();
        }
    }
}
