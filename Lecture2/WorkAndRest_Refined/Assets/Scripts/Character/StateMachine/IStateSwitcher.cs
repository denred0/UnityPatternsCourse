using System;

public interface IStateSwitcher {

    //void SwitchState<State>() where State : IState;
    void SwitchState(Type stateType);

}
