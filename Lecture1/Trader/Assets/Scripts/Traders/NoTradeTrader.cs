using UnityEngine;

public class NoTradeTrader : Trader {
    protected override void Trade(IReputationPicker reputationPicker) {
        Debug.Log("I don't trade");
    }
}
