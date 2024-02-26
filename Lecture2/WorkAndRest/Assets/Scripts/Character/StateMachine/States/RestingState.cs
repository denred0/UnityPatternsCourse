using UnityEngine;

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
            StateSwitcher.SwitchState<RunningState>();
        }
    }
}
