using System.Collections.Generic;
using UnityEngine;

public class GreenBallStrategy : IWinStrategy {
    private int _collectedBalls;
    private Ball.BallType _collectedBall;
    private Dictionary<Ball.BallType, int> _ballsDict;

    public GreenBallStrategy(Dictionary<Ball.BallType, int> ballsDict, Ball.BallType collectedBall) {
        _ballsDict = ballsDict;
        _collectedBall = collectedBall;
    }


    public void CheckWin() {
        if (_collectedBall == Ball.BallType.Green) {
            _collectedBalls += 1;
        }

        if (_collectedBalls == _ballsDict[Ball.BallType.Green]) {
            Debug.Log("You win!");
        }
    }
}
