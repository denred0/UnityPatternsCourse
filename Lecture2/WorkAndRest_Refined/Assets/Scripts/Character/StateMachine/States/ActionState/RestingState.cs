using UnityEngine;

public class RestingState : ActionState
{
    private CharacterConfig _characterConfig;
    private RestingStateConfig _restingStateConfig;
    private WorkingStateConfig _workingStateConfig;


    public RestingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character, StatesPoints statesPoints) : base(stateSwitcher, data, character, statesPoints)
    {
        _characterConfig = character.Config;
        _restingStateConfig = character.Config.RestingStateConfig;
        _workingStateConfig = character.Config.WorkingStateConfig;
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
            Data.CurrentActionPoint = _workingStateConfig.WorkingPosition.transform.position;
        }
    }
}
