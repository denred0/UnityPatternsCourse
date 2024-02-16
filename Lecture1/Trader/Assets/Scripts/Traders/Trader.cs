using UnityEngine;

public abstract class Trader : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        if (other.transform.TryGetComponent(out IReputationPicker reputationPicker)) {
            Trade(reputationPicker);
        }
    }

    protected abstract void Trade(IReputationPicker reputationPicker);

}
