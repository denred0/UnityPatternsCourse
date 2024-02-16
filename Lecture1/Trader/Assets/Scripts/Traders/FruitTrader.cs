using UnityEngine;

public class FruitTrader : Trader {

    [SerializeField, Range(5, 20)] private int _minTradeReputation;
    protected override void Trade(IReputationPicker reputationPicker) {
        if (reputationPicker.Reputation > _minTradeReputation) {
            Debug.Log("I can sell you fruit");
        } else {
            Debug.Log("You don't have enough reputation");
        }
    }
}
