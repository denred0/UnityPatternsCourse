using UnityEngine;

public class ArmorTrader : Trader
{
    [SerializeField, Range(20, 50)] private int _minTradeReputation;
    protected override void Trade(IReputationPicker reputationPicker) {
        if (reputationPicker.Reputation > _minTradeReputation) {
            Debug.Log("I can sell you armor");
        } else {
            Debug.Log("You don't have enough reputation");
        }
    }
}
