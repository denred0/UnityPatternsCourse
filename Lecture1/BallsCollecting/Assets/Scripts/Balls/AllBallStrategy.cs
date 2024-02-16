using System.Collections.Generic;
using UnityEngine;

public class AllBallStrategy : IWinStrategy {
    private int _allBalls;
    private int _collectedBalls;

    public AllBallStrategy(Dictionary<Ball.BallType, int> ballsDict) {
        _allBalls = ballsDict[Ball.BallType.White] + ballsDict[Ball.BallType.Red] + ballsDict[Ball.BallType.Green];
    }


    public void CheckWin() {
        _collectedBalls += 1;

        if (_collectedBalls == _allBalls) {
            Debug.Log("You win!");
        }
    }
}
