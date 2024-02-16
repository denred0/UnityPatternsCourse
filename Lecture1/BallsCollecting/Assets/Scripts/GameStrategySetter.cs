using UnityEngine;

public class GameStrategySetter : MonoBehaviour {
    [SerializeField] private Player _player;

    private void Start() {
        _player.SetWinStrategy(new RedBallStrategy(Ball.BallTypesCountDict, Ball.BallType.Red));
        Debug.Log("You need to collect RED balls to win!");
    }


    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            _player.SetWinStrategy(new RedBallStrategy(Ball.BallTypesCountDict, Ball.BallType.Red));
            Debug.Log("You need to collect RED balls to win!");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            _player.SetWinStrategy(new GreenBallStrategy(Ball.BallTypesCountDict, Ball.BallType.Green));
            Debug.Log("You need to collect GREEN balls to win!");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            _player.SetWinStrategy(new WhiteBallStrategy(Ball.BallTypesCountDict, Ball.BallType.White));
            Debug.Log("You need to collect WHITE balls to win!");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            _player.SetWinStrategy(new AllBallStrategy(Ball.BallTypesCountDict));
            Debug.Log("You need to collect ALL balls to win!");
        }
    }
}
