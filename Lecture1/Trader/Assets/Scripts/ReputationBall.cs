using UnityEngine;

public class ReputationBall : MonoBehaviour {

    [SerializeField, Range(0, 50)] private int _reputationAmount;


    private void OnTriggerEnter(Collider other) {
        if (other.transform.TryGetComponent(out IReputationPicker reputationPicker)) {
            reputationPicker.AddReputation(_reputationAmount);
            Destroy(gameObject);
        }
    }

}
