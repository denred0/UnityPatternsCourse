using System;
using System.Collections.Generic;
using System.Linq;

public class CharacterStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public CharacterStateMachine(Character character)
    {
        StatesPoints statesPoints = new StatesPoints(character.Config);

        StateMachineData data = new StateMachineData();

        _states = new List<IState>()
        {
            new RunningState(this, data, character, statesPoints),
            new RestingState(this, data, character, statesPoints),
            new WorkingState(this, data, character, statesPoints),
        };

        _currentState = _states[0];
        _currentState.Enter();
    }

    public void SwitchState(Type stateType)
    {
        if (!typeof(IState).IsAssignableFrom(stateType))
            throw new ArgumentException($"newStateType({stateType.Name}) is not inherited from IState");

        _currentState?.Exit();
        _currentState = _states.FirstOrDefault(state => stateType.IsEquivalentTo(state.GetType()));
        _currentState.Enter();
    }

    public void Update() => _currentState.Update();
}
