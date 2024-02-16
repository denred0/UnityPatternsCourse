using System.Collections.Generic;
using UnityEngine;

public class RedBallStrategy : IWinStrategy {
    private int _collectedBalls;
    private Ball.BallType _collectedBall;
    private Dictionary<Ball.BallType, int> _ballsDict;

    public RedBallStrategy(Dictionary<Ball.BallType, int> ballsDict, Ball.BallType collectedBall) {
        _ballsDict = ballsDict;
        _collectedBall = collectedBall;
    }


    public void CheckWin() {
        if (_collectedBall == Ball.BallType.Red) {
            _collectedBalls += 1;
        }

        if (_collectedBalls == _ballsDict[Ball.BallType.Red]) {
            Debug.Log("You win!");
        }
    }
}
