using UnityEngine;

public class Player : MonoBehaviour {

    IWinStrategy _winStrategy;

    public void SetWinStrategy(IWinStrategy winStrategy) {
        _winStrategy = winStrategy;
    }

    private void OnCollisionEnter(Collision collision) {
        if (_winStrategy == null)
            return;
        
        if (collision.gameObject.TryGetComponent(out Ball ball)) {
            Debug.Log($"{ball.CurrentBallType} ball collected!");
            _winStrategy.CheckWin();
            Destroy(ball.gameObject);
        }
    }

}
