using System.Collections.Generic;
using UnityEngine;

public class WhiteBallStrategy : IWinStrategy {
    private int _collectedBalls;
    private Ball.BallType _collectedBall;
    private Dictionary<Ball.BallType, int> _ballsDict;

    public WhiteBallStrategy(Dictionary<Ball.BallType, int> ballsDict, Ball.BallType collectedBall) {
        _ballsDict = ballsDict;
        _collectedBall = collectedBall;
    }


    public void CheckWin() {
        if (_collectedBall == Ball.BallType.White) {
            _collectedBalls += 1;
        }

        if (_collectedBalls == _ballsDict[Ball.BallType.White]) {
            Debug.Log("You win!");
        }
    }
}
