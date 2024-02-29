using UnityEngine;

public class WorkingState : ActionState
{ 
    private WorkingStateConfig _workingStateConfig;
    private RestingStateConfig _restingStateConfig;


    public WorkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character, StatesPoints statesPoints) : base(stateSwitcher, data, character, statesPoints)
    {
        _workingStateConfig = character.Config.WorkingStateConfig;
        _restingStateConfig = character.Config.RestingStateConfig;  
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

        Data.Energy -= _workingStateConfig.EnergyDecreasingAmount; 
        Debug.Log($"Energy: {Data.Energy}");

        if (Data.Energy <= 0)
        {
            Data.Energy = 0;
            Data.CurrentActionPoint = _restingStateConfig.RestingPosition.transform.position;
        }
    }
}
